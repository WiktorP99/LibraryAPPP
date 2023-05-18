USE [LibraryDB]
GO

/****** Object:  StoredProcedure [dbo].[GetRentInfo]    Script Date: 18.05.2023 23:52:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetRentInfo]
	@ClientId int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	Select x.*, 
	y.ReturnDate, 
	z.PenaltyFee,
	z.DelayDays,
	s.Title 
	from Clients x 
		left join RentHeader y 
			on x.ClientId = y.ClientId
		left join RentDetail z 
			on y.RentHeaderId = z.RentHeaderId
		left join Books s 
			on s.BookId = z.BookId
	where z.PenaltyFee is not null and x.ClientId = @ClientId
END
GO


