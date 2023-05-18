USE [LibraryDB]
GO

/****** Object:  StoredProcedure [dbo].[CheckAndChargeDelays]    Script Date: 18.05.2023 23:52:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CheckAndChargeDelays] AS
BEGIN
    DECLARE @currentDate datetime;
    SET @currentDate = GETDATE();

    -- Wybieramy wypo¿yczenia, które powinny zostaæ ju¿ zwrócone
    DECLARE @overdueRentals TABLE (
        RentHeaderId int,
        ClientId int,
        BookId int,
        ExpectedReturnDate datetime,
        DelayDays smallint
    );

    INSERT INTO @overdueRentals
    SELECT rh.RentHeaderId, rh.ClientId, rd.BookId, rh.ReturnDate, DATEDIFF(DAY, rh.ReturnDate, @currentDate)
    FROM dbo.RentHeader rh
    JOIN dbo.RentDetail rd ON rh.RentHeaderId = rd.RentHeaderId
    WHERE rh.ReturnDate < @currentDate
    AND rh.RentStatusId != (SELECT RentStatusId FROM dbo.RentStatus WHERE StatusName = 'Returned');

    -- Naliczamy opóŸnienia z progresywn¹ stawk¹ karn¹
    UPDATE dbo.RentDetail
    SET DelayDays = ors.DelayDays,
        PenaltyFee = CASE
            WHEN ors.DelayDays <= 10 THEN ors.DelayDays * 2.0  -- op³ata karna 2.0 za dzieñ opóŸnienia do 10 dni
            WHEN ors.DelayDays <= 30 THEN ors.DelayDays * 3.0  -- op³ata karna 3.0 za dzieñ opóŸnienia dla 11-30 dni
            ELSE ors.DelayDays * 4.0  -- op³ata karna 4.0 za dzieñ opóŸnienia dla opóŸnieñ powy¿ej 30 dni
        END
    FROM dbo.RentDetail rd
    JOIN @overdueRentals ors ON rd.RentHeaderId = ors.RentHeaderId
    WHERE rd.BookId = ors.BookId;

    -- Zmieniamy status wypo¿yczeñ na Delayed je¿eli s¹ opóŸnione
    UPDATE dbo.RentHeader
    SET RentStatusId = (SELECT RentStatusId FROM dbo.RentStatus WHERE StatusName = 'Delayed')
    FROM dbo.RentHeader rh
    JOIN @overdueRentals ors ON rh.RentHeaderId = ors.RentHeaderId;

    -- Blokujemy u¿ytkowników, którzy spóŸnili siê o wiêcej ni¿ 30 dni
    UPDATE dbo.Clients
    SET Blocked = 1
    WHERE ClientId IN (
        SELECT ClientId 
        FROM @overdueRentals
        WHERE DelayDays > 30
    );
END;
GO


