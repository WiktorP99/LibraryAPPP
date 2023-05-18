USE [LibraryDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorFirstName] [nvarchar](50) NULL,
	[AuthorLastName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[PublicationDate] [datetime] NULL,
	[Price] [decimal](9, 2) NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[ClientFirstName] [nvarchar](50) NOT NULL,
	[ClientLastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Province] [nvarchar](30) NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[PostalCode] [nvarchar](6) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Blocked] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentDetail]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentDetail](
	[RentDetailId] [int] IDENTITY(1,1) NOT NULL,
	[RentHeaderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Amount] [smallint] NOT NULL,
	[DelayDays] [smallint] NULL,
	[PenaltyFee] [decimal](9, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[RentDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentHeader]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentHeader](
	[RentHeaderId] [int] IDENTITY(1,1) NOT NULL,
	[RentStatusId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[RentDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentHeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentStatus]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentStatus](
	[RentStatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RentStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderDetail]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetail](
	[SalesOrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[SalesOrderHeaderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [decimal](9, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesOrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderHeader]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderHeader](
	[SalesOrderHeaderId] [int] IDENTITY(1,1) NOT NULL,
	[SalesOrderStatusId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesOrderHeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderStatus]    Script Date: 18.05.2023 23:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderStatus](
	[SalesOrderStatus] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesOrderStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (1, N'J.K.', N'Rowling')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (2, N'Stephen', N'King')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (3, N'Harper', N'Lee')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (4, N'George', N'Orwell')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (5, N'Agatha', N'Christie')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (9, N'Jan', N'Nowak')
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorFirstName], [AuthorLastName]) VALUES (10, N'Jan', N'Kowalski')
GO
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (1, N'Harry Potter and the Philosopher''s Stone', 1, CAST(N'1997-06-26T00:00:00.000' AS DateTime), CAST(29.99 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (2, N'Harry Potter and the Chamber of Secrets', 1, CAST(N'1998-07-02T00:00:00.000' AS DateTime), CAST(32.99 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (3, N'Harry Potter and the Prisoner of Azkaban', 1, CAST(N'1999-07-08T00:00:00.000' AS DateTime), CAST(34.99 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (4, N'Harry Potter and the Goblet of Fire', 1, CAST(N'2000-07-08T00:00:00.000' AS DateTime), NULL, 11)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (5, N'Harry Potter and the Order of the Phoenix', 1, CAST(N'2003-06-21T00:00:00.000' AS DateTime), CAST(36.99 AS Decimal(9, 2)), 0)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (6, N'Harry Potter and the Half-Blood Prince', 1, CAST(N'2005-07-16T00:00:00.000' AS DateTime), CAST(38.99 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (7, N'Harry Potter and the Deathly Hallows', 1, CAST(N'2007-07-21T00:00:00.000' AS DateTime), NULL, 6)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (8, N'The Stand', 2, CAST(N'1978-10-03T00:00:00.000' AS DateTime), CAST(27.99 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (9, N'It', 2, CAST(N'1986-09-15T00:00:00.000' AS DateTime), CAST(24.99 AS Decimal(9, 2)), 15)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (10, N'Carrie', 2, CAST(N'1974-04-05T00:00:00.000' AS DateTime), NULL, 10)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (11, N'To Kill a Mockingbird', 3, CAST(N'1960-07-11T00:00:00.000' AS DateTime), CAST(19.99 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (12, N'1984', 4, CAST(N'1949-06-08T00:00:00.000' AS DateTime), CAST(18.99 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (13, N'Animal Farm', 4, CAST(N'1945-08-17T00:00:00.000' AS DateTime), CAST(16.99 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (14, N'Murder on the Orient Express', 5, CAST(N'1934-01-01T00:00:00.000' AS DateTime), CAST(14.99 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (15, N'And Then There Were None', 5, CAST(N'1939-11-06T00:00:00.000' AS DateTime), CAST(17.99 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (16, N'The Murder of Roger Ackroyd', 5, CAST(N'1926-06-19T00:00:00.000' AS DateTime), NULL, 7)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (19, N'Tytuł książki', 9, CAST(N'2023-05-25T00:00:00.000' AS DateTime), CAST(1.00 AS Decimal(9, 2)), 0)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (20, N'test', 9, CAST(N'2023-05-24T00:00:00.000' AS DateTime), CAST(20.99 AS Decimal(9, 2)), 23)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (21, N'test2', 9, CAST(N'2023-05-25T00:00:00.000' AS DateTime), CAST(100.50 AS Decimal(9, 2)), 60)
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorId], [PublicationDate], [Price], [Quantity]) VALUES (22, N'test 3', 10, CAST(N'2023-05-16T00:00:00.000' AS DateTime), CAST(21.99 AS Decimal(9, 2)), 14)
GO
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (1, N'Jan', N'Kowalski', N'jan.kowalski@example.com', N'Mazowieckie', N'Warszawa', N'00-001', N'Piotrkowska 1', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (2, N'Anna', N'Nowak', N'anna.nowak@example.com', N'Małopolskie', N'Kraków', N'30-001', N'Główna 10', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (3, N'Katarzyna', N'Wiśniewska', N'katarzyna.wisniewska@example.com', N'Śląskie', N'Katowice', N'40-001', N'Narutowicza 5', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (4, N'Piotr', N'Wójcik', N'piotr.wojcik@example.com', N'Wielkopolskie', N'Poznań', N'60-001', N'Mickiewicza 20', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (5, N'Magdalena', N'Kaczmarek', N'magdalena.kaczmarek@example.com', N'Dolnośląskie', N'Wrocław', N'50-001', N'Szewska 15', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (6, N'Marcin', N'Lewandowski', N'marcin.lewandowski@example.com', N'Łódzkie', N'Łódź', N'90-001', N'Sienkiewicza 30', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (7, N'Aleksandra', N'Dąbrowska', N'aleksandra.dabrowska@example.com', N'Pomorskie', N'Gdańsk', N'80-001', N'Długa 25', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (8, N'Robert', N'Szymański', N'robert.szymanski@example.com', N'Zachodniopomorskie', N'Szczecin', N'70-001', N'Wojska Polskiego 12', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (9, N'Monika', N'Jankowska', N'monika.jankowska@example.com', N'Podkarpackie', N'Rzeszów', N'35-001', N'Podwisłocze 8', 0)
GO
INSERT [dbo].[Clients] ([ClientId], [ClientFirstName], [ClientLastName], [Email], [Province], [City], [PostalCode], [Address], [Blocked]) VALUES (10, N'Adam', N'Michalski', N'adam.michalski@example.com', N'Lubelskie', N'Lublin', N'20-001', N'Piekna 5', 0)
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO


SET IDENTITY_INSERT [dbo].[RentStatus] ON 
GO
INSERT [dbo].[RentStatus] ([RentStatusId], [StatusName]) VALUES (1, N'Rented')
GO
INSERT [dbo].[RentStatus] ([RentStatusId], [StatusName]) VALUES (2, N'Returned')
GO
INSERT [dbo].[RentStatus] ([RentStatusId], [StatusName]) VALUES (3, N'Delayed')
GO
SET IDENTITY_INSERT [dbo].[RentStatus] OFF
GO



SET IDENTITY_INSERT [dbo].[SalesOrderStatus] ON 
GO
INSERT [dbo].[SalesOrderStatus] ([SalesOrderStatus], [StatusName]) VALUES (1, N'Bought')
GO
INSERT [dbo].[SalesOrderStatus] ([SalesOrderStatus], [StatusName]) VALUES (2, N'Ordered')
GO
INSERT [dbo].[SalesOrderStatus] ([SalesOrderStatus], [StatusName]) VALUES (3, N'Sended')
GO
INSERT [dbo].[SalesOrderStatus] ([SalesOrderStatus], [StatusName]) VALUES (4, N'Delivered')
GO
SET IDENTITY_INSERT [dbo].[SalesOrderStatus] OFF
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [Blocked]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[RentDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentDetail_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[RentDetail] CHECK CONSTRAINT [FK_RentDetail_Books]
GO
ALTER TABLE [dbo].[RentDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentDetail_RentHeader] FOREIGN KEY([RentHeaderId])
REFERENCES [dbo].[RentHeader] ([RentHeaderId])
GO
ALTER TABLE [dbo].[RentDetail] CHECK CONSTRAINT [FK_RentDetail_RentHeader]
GO
ALTER TABLE [dbo].[RentHeader]  WITH CHECK ADD  CONSTRAINT [FK_RentHeader_Customer] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[RentHeader] CHECK CONSTRAINT [FK_RentHeader_Customer]
GO
ALTER TABLE [dbo].[RentHeader]  WITH CHECK ADD  CONSTRAINT [FK_RentHeader_RentStatus] FOREIGN KEY([RentStatusId])
REFERENCES [dbo].[RentStatus] ([RentStatusId])
GO
ALTER TABLE [dbo].[RentHeader] CHECK CONSTRAINT [FK_RentHeader_RentStatus]
GO
ALTER TABLE [dbo].[SalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetail_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[SalesOrderDetail] CHECK CONSTRAINT [FK_SalesOrderDetail_Books]
GO
ALTER TABLE [dbo].[SalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetail_Header] FOREIGN KEY([SalesOrderHeaderId])
REFERENCES [dbo].[SalesOrderHeader] ([SalesOrderHeaderId])
GO
ALTER TABLE [dbo].[SalesOrderDetail] CHECK CONSTRAINT [FK_SalesOrderDetail_Header]
GO
ALTER TABLE [dbo].[SalesOrderHeader]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderHeader_Books] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[SalesOrderHeader] CHECK CONSTRAINT [FK_SalesOrderHeader_Books]
GO
ALTER TABLE [dbo].[SalesOrderHeader]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderHeader_Status] FOREIGN KEY([SalesOrderStatusId])
REFERENCES [dbo].[SalesOrderStatus] ([SalesOrderStatus])
GO
ALTER TABLE [dbo].[SalesOrderHeader] CHECK CONSTRAINT [FK_SalesOrderHeader_Status]
GO
