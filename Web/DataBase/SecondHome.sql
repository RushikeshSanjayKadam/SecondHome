USE [SecondHomeDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTbl](
	[AdminID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminTbl] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BedType]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BedType](
	[BedTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[BedTypeName] [nvarchar](max) NULL,
	[HotelID] [bigint] NOT NULL,
 CONSTRAINT [PK_BedType] PRIMARY KEY CLUSTERED 
(
	[BedTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingCheckInTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingCheckInTbl](
	[BookingCheckInID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingCheckInDate] [datetime2](7) NOT NULL,
	[NoofAdults] [nvarchar](max) NULL,
	[NoofChilds] [nvarchar](max) NULL,
	[PersonName] [nvarchar](max) NULL,
	[IsAddressProofFilePath] [nvarchar](max) NULL,
	[BookingID] [bigint] NOT NULL,
	[DocumentType] [bigint] NOT NULL,
 CONSTRAINT [PK_BookingCheckInTbl] PRIMARY KEY CLUSTERED 
(
	[BookingCheckInID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingCheckOutTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingCheckOutTbl](
	[BookingCheckOutID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingCheckOutDate] [datetime2](7) NOT NULL,
	[BookingID] [bigint] NOT NULL,
 CONSTRAINT [PK_BookingCheckOutTbl] PRIMARY KEY CLUSTERED 
(
	[BookingCheckOutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingTbl](
	[BookingID] [bigint] IDENTITY(1,1) NOT NULL,
	[BookingDate] [datetime2](7) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[HotelID] [bigint] NOT NULL,
 CONSTRAINT [PK_BookingTbl] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookinRoomTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookinRoomTbl](
	[BookingRoomID] [bigint] IDENTITY(1,1) NOT NULL,
	[FromDate] [datetime2](7) NOT NULL,
	[ToDate] [datetime2](7) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[RoomID] [bigint] NOT NULL,
 CONSTRAINT [PK_BookinRoomTbl] PRIMARY KEY CLUSTERED 
(
	[BookingRoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuildingTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuildingTbl](
	[BuildingID] [bigint] IDENTITY(1,1) NOT NULL,
	[BuildingName] [nvarchar](max) NULL,
	[HotelID] [bigint] NOT NULL,
 CONSTRAINT [PK_BuildingTbl] PRIMARY KEY CLUSTERED 
(
	[BuildingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CancelBookingTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CancelBookingTbl](
	[CancelBookingID] [bigint] IDENTITY(1,1) NOT NULL,
	[CancelBookingDate] [datetime2](7) NOT NULL,
	[ReasonToCancel] [nvarchar](max) NULL,
	[IsAdvance] [bit] NOT NULL,
	[BookingID] [bigint] NOT NULL,
 CONSTRAINT [PK_CancelBookingTbl] PRIMARY KEY CLUSTERED 
(
	[CancelBookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NULL,
	[StateID] [bigint] NOT NULL,
	[CountryID] [bigint] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CountryTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryTbl](
	[CountryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CountryTbl] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FloorTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FloorTbl](
	[FloorID] [bigint] IDENTITY(1,1) NOT NULL,
	[FloorNumber] [nvarchar](max) NULL,
	[BuildingID] [bigint] NOT NULL,
 CONSTRAINT [PK_FloorTbl] PRIMARY KEY CLUSTERED 
(
	[FloorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelRatingTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelRatingTbl](
	[HotelRatingID] [bigint] IDENTITY(1,1) NOT NULL,
	[Rating] [int] NOT NULL,
	[Review] [nvarchar](max) NULL,
	[HotelID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
 CONSTRAINT [PK_HotelRatingTbl] PRIMARY KEY CLUSTERED 
(
	[HotelRatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelTbl](
	[HotelID] [bigint] IDENTITY(1,1) NOT NULL,
	[HotelName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[ContactNo] [nvarchar](max) NULL,
	[ContactPersonName] [nvarchar](max) NULL,
	[WebSiteUrl] [nvarchar](max) NULL,
	[LogoFilePath] [nvarchar](max) NULL,
	[IsGSTApplicable] [bit] NOT NULL,
	[GSTINNo] [nvarchar](max) NULL,
	[CityID] [bigint] NOT NULL,
 CONSTRAINT [PK_HotelTbl] PRIMARY KEY CLUSTERED 
(
	[HotelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime2](7) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
	[TaxPercentage] [decimal](18, 2) NOT NULL,
	[CheckOutID] [bigint] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceTaxTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceTaxTbl](
	[InvoiceTaxID] [bigint] IDENTITY(1,1) NOT NULL,
	[TaxPercentage] [decimal](18, 2) NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
	[InvoiceID] [bigint] NOT NULL,
 CONSTRAINT [PK_InvoiceTaxTbl] PRIMARY KEY CLUSTERED 
(
	[InvoiceTaxID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTbl](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[PaymentMethod] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[IsAdvance] [bit] NOT NULL,
	[BookingID] [bigint] NOT NULL,
 CONSTRAINT [PK_PaymentTbl] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomBedTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomBedTbl](
	[RoomBedID] [bigint] IDENTITY(1,1) NOT NULL,
	[NoofBeds] [nvarchar](max) NULL,
	[BedTypeID] [bigint] NOT NULL,
 CONSTRAINT [PK_RoomBedTbl] PRIMARY KEY CLUSTERED 
(
	[RoomBedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomCategoryTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomCategoryTbl](
	[RoomCategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoomCategoryName] [nvarchar](max) NULL,
	[BaseCharges] [decimal](18, 2) NOT NULL,
	[HotelID] [bigint] NOT NULL,
 CONSTRAINT [PK_RoomCategoryTbl] PRIMARY KEY CLUSTERED 
(
	[RoomCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomPhototTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomPhototTbl](
	[RoomPhotoID] [bigint] IDENTITY(1,1) NOT NULL,
	[PhotoTitle] [nvarchar](max) NULL,
	[PhotoFilePath] [nvarchar](max) NULL,
	[UploadDate] [datetime2](7) NOT NULL,
	[RoomID] [bigint] NOT NULL,
 CONSTRAINT [PK_RoomPhototTbl] PRIMARY KEY CLUSTERED 
(
	[RoomPhotoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomServiceTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomServiceTbl](
	[RoomServiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoomServiceName] [nvarchar](max) NULL,
	[RoomServicePrice] [decimal](18, 2) NOT NULL,
	[RoomCategoryID] [bigint] NOT NULL,
	[HotelID] [bigint] NOT NULL,
 CONSTRAINT [PK_RoomServiceTbl] PRIMARY KEY CLUSTERED 
(
	[RoomServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTbl](
	[RoomID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [nvarchar](max) NULL,
	[RoomCharges] [decimal](18, 2) NOT NULL,
	[MaxNoofAdults] [nvarchar](max) NULL,
	[MaxNoofChilds] [nvarchar](max) NULL,
	[RoomCategoryID] [bigint] NOT NULL,
	[FloorID] [bigint] NOT NULL,
	[RoomPhotos] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoomTbl] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateTbl](
	[StateID] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
	[CountryID] [bigint] NOT NULL,
 CONSTRAINT [PK_StateTbl] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxTbl](
	[TaxID] [bigint] IDENTITY(1,1) NOT NULL,
	[TaxPercentage] [decimal](18, 2) NOT NULL,
	[HSNSACNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_TaxTbl] PRIMARY KEY CLUSTERED 
(
	[TaxID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 04-06-2024 14:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[UserEmail] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[DateofBirth] [datetime2](7) NOT NULL,
	[Gender] [nvarchar](max) NULL,
	[CityID] [bigint] NOT NULL,
 CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425041922_Models', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240510122247_Categories_name_change', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240513090828_Room_RoomPhotos_Added', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240515101457_Tax_Invoice_Changes', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240516122513_Photos', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240520050208_Int_To_String', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240523112734_Changes', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240524052036_Changes_1', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240525081600_CancelBooking_Changes', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240525102149_Payment_Changes', N'7.0.18')
GO
SET IDENTITY_INSERT [dbo].[AdminTbl] ON 

INSERT [dbo].[AdminTbl] ([AdminID], [FirstName], [LastName], [EmailID], [MobileNo], [Password]) VALUES (1, N'Rushikesh', N'Kadam', N'rskadam1176@gmail.com', N'1234567890', N'1176')
SET IDENTITY_INSERT [dbo].[AdminTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BedType] ON 

INSERT [dbo].[BedType] ([BedTypeID], [BedTypeName], [HotelID]) VALUES (1, N'Double', 5)
INSERT [dbo].[BedType] ([BedTypeID], [BedTypeName], [HotelID]) VALUES (2, N'Queen', 5)
INSERT [dbo].[BedType] ([BedTypeID], [BedTypeName], [HotelID]) VALUES (3, N'King', 5)
INSERT [dbo].[BedType] ([BedTypeID], [BedTypeName], [HotelID]) VALUES (4, N'Standard', 5)
INSERT [dbo].[BedType] ([BedTypeID], [BedTypeName], [HotelID]) VALUES (6, N'Double', 9)
SET IDENTITY_INSERT [dbo].[BedType] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingCheckInTbl] ON 

INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (2, CAST(N'2024-05-24T09:51:02.5057330' AS DateTime2), N'4', N'2', N'Rushikesh Kadam', NULL, 44, 0)
INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (3, CAST(N'2024-05-24T15:52:53.0863321' AS DateTime2), N'4', N'2', N'Rushikesh Kadam', NULL, 47, 0)
INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (4, CAST(N'2024-05-24T17:30:15.5201227' AS DateTime2), N'4', N'2', N'Sandesh Bhale', NULL, 48, 0)
INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (5, CAST(N'2024-05-25T18:24:27.2640886' AS DateTime2), N'4', N'2', N'Shivam Ingle', NULL, 45, 0)
INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (6, CAST(N'2024-05-25T19:38:32.2671390' AS DateTime2), N'4', N'2', N'Shivam Ingle', NULL, 49, 0)
INSERT [dbo].[BookingCheckInTbl] ([BookingCheckInID], [BookingCheckInDate], [NoofAdults], [NoofChilds], [PersonName], [IsAddressProofFilePath], [BookingID], [DocumentType]) VALUES (7, CAST(N'2024-05-27T12:16:03.5913449' AS DateTime2), N'5', N'2', N'Rushikesh Kadam', NULL, 50, 0)
SET IDENTITY_INSERT [dbo].[BookingCheckInTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingCheckOutTbl] ON 

INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (1, CAST(N'2024-05-31T11:06:00.0000000' AS DateTime2), 44)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (2, CAST(N'2024-06-02T15:53:00.0000000' AS DateTime2), 47)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (3, CAST(N'2024-06-02T17:30:00.0000000' AS DateTime2), 48)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (6, CAST(N'2024-05-31T14:41:00.0000000' AS DateTime2), 48)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (7, CAST(N'2024-05-31T18:18:00.0000000' AS DateTime2), 47)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (8, CAST(N'2024-05-24T18:20:00.0000000' AS DateTime2), 44)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (9, CAST(N'2024-05-31T19:38:00.0000000' AS DateTime2), 49)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (10, CAST(N'2024-05-31T19:38:00.0000000' AS DateTime2), 49)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (11, CAST(N'2024-05-26T10:31:00.0000000' AS DateTime2), 45)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (12, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 45)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (13, CAST(N'2024-05-31T12:16:00.0000000' AS DateTime2), 50)
INSERT [dbo].[BookingCheckOutTbl] ([BookingCheckOutID], [BookingCheckOutDate], [BookingID]) VALUES (14, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 50)
SET IDENTITY_INSERT [dbo].[BookingCheckOutTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BookingTbl] ON 

INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (44, CAST(N'2024-05-23T16:00:48.1494310' AS DateTime2), 2, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (45, CAST(N'2024-05-23T19:06:44.0878919' AS DateTime2), 8, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (46, CAST(N'2024-05-24T09:54:43.2332655' AS DateTime2), 2, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (47, CAST(N'2024-05-24T15:51:56.3595053' AS DateTime2), 2, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (48, CAST(N'2024-05-24T17:29:35.5888543' AS DateTime2), 2, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (49, CAST(N'2024-05-25T18:49:23.6032164' AS DateTime2), 2, 9)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (50, CAST(N'2024-05-27T12:15:27.5929353' AS DateTime2), 2, 5)
INSERT [dbo].[BookingTbl] ([BookingID], [BookingDate], [UserID], [HotelID]) VALUES (51, CAST(N'2024-05-27T12:18:11.2800196' AS DateTime2), 2, 5)
SET IDENTITY_INSERT [dbo].[BookingTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BookinRoomTbl] ON 

INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (6, CAST(N'2024-05-24T15:58:00.0000000' AS DateTime2), CAST(N'2024-05-31T15:58:00.0000000' AS DateTime2), 2, 19)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (7, CAST(N'2024-05-24T16:00:00.0000000' AS DateTime2), CAST(N'2024-05-31T16:00:00.0000000' AS DateTime2), 2, 19)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (8, CAST(N'2024-05-28T19:06:00.0000000' AS DateTime2), CAST(N'2024-06-05T19:06:00.0000000' AS DateTime2), 8, 20)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (9, CAST(N'2024-05-26T09:54:00.0000000' AS DateTime2), CAST(N'2024-06-02T09:54:00.0000000' AS DateTime2), 2, 20)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (10, CAST(N'2024-05-25T15:51:00.0000000' AS DateTime2), CAST(N'2024-06-01T15:51:00.0000000' AS DateTime2), 2, 23)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (11, CAST(N'2024-05-25T17:29:00.0000000' AS DateTime2), CAST(N'2024-06-02T17:29:00.0000000' AS DateTime2), 2, 10)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (12, CAST(N'2024-05-25T18:48:00.0000000' AS DateTime2), CAST(N'2024-06-07T18:48:00.0000000' AS DateTime2), 2, 27)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (13, CAST(N'2024-05-27T12:15:00.0000000' AS DateTime2), CAST(N'2024-05-31T12:15:00.0000000' AS DateTime2), 2, 19)
INSERT [dbo].[BookinRoomTbl] ([BookingRoomID], [FromDate], [ToDate], [UserID], [RoomID]) VALUES (14, CAST(N'2024-05-28T12:17:00.0000000' AS DateTime2), CAST(N'2024-05-31T12:18:00.0000000' AS DateTime2), 2, 22)
SET IDENTITY_INSERT [dbo].[BookinRoomTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[BuildingTbl] ON 

INSERT [dbo].[BuildingTbl] ([BuildingID], [BuildingName], [HotelID]) VALUES (1, N'Suites', 5)
INSERT [dbo].[BuildingTbl] ([BuildingID], [BuildingName], [HotelID]) VALUES (2, N'Deluxes', 5)
INSERT [dbo].[BuildingTbl] ([BuildingID], [BuildingName], [HotelID]) VALUES (4, N'Rooms', 5)
INSERT [dbo].[BuildingTbl] ([BuildingID], [BuildingName], [HotelID]) VALUES (5, N'Villas', 5)
INSERT [dbo].[BuildingTbl] ([BuildingID], [BuildingName], [HotelID]) VALUES (13, N'Suites', 9)
SET IDENTITY_INSERT [dbo].[BuildingTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CancelBookingTbl] ON 

INSERT [dbo].[CancelBookingTbl] ([CancelBookingID], [CancelBookingDate], [ReasonToCancel], [IsAdvance], [BookingID]) VALUES (1, CAST(N'2024-05-31T13:51:00.0000000' AS DateTime2), N'Holiday got cancelled', 0, 46)
INSERT [dbo].[CancelBookingTbl] ([CancelBookingID], [CancelBookingDate], [ReasonToCancel], [IsAdvance], [BookingID]) VALUES (2, CAST(N'2024-05-28T12:18:00.0000000' AS DateTime2), N'Holiday got cancelled', 1, 51)
SET IDENTITY_INSERT [dbo].[CancelBookingTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (4, N'Parbhani', 3, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (14, N'SambhajiNagar', 3, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (15, N'Pune', 3, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (16, N'Surat', 16, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (17, N'Ahmedabad', 16, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (18, N'Vadodara', 16, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (19, N'Kanpur', 17, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (20, N'Lakhnaw', 17, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (21, N'Ayodhya', 17, 1)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (25, N'Belmont', 19, 2)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (26, N'FrankFort ', 19, 2)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (27, N'Fort Edward', 19, 2)
INSERT [dbo].[City] ([CityID], [CityName], [StateID], [CountryID]) VALUES (28, N'Belmont1', 19, 2)
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[CountryTbl] ON 

INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (1, N'India')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (2, N'USA')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (3, N'Russia')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (4, N'Germany')
SET IDENTITY_INSERT [dbo].[CountryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[FloorTbl] ON 

INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (1, N'S1', 1)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (2, N'S2', 1)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (3, N'S3', 1)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (4, N'D1', 2)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (5, N'D2', 2)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (6, N'D3', 2)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (9, N'R1', 4)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (10, N'R2', 4)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (11, N'R3', 4)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (12, N'V1', 5)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (13, N'V2', 5)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (14, N'V3', 5)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (15, N'CPS1', 13)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (16, N'CPS2', 13)
INSERT [dbo].[FloorTbl] ([FloorID], [FloorNumber], [BuildingID]) VALUES (17, N'CPS3', 13)
SET IDENTITY_INSERT [dbo].[FloorTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[HotelTbl] ON 

INSERT [dbo].[HotelTbl] ([HotelID], [HotelName], [Address], [EmailID], [Password], [ContactNo], [ContactPersonName], [WebSiteUrl], [LogoFilePath], [IsGSTApplicable], [GSTINNo], [CityID]) VALUES (5, N'Conrad', N'Near Koregaon Park,Pune', N'conrad@gmail.com', N'1176', N'Rushikesh', N'8208391176', N'www.conrad.com', NULL, 1, N'627612', 4)
INSERT [dbo].[HotelTbl] ([HotelID], [HotelName], [Address], [EmailID], [Password], [ContactNo], [ContactPersonName], [WebSiteUrl], [LogoFilePath], [IsGSTApplicable], [GSTINNo], [CityID]) VALUES (9, N'City Palace', NULL, N'citypalace@gmail.com', N'1176', NULL, NULL, NULL, NULL, 0, NULL, 4)
SET IDENTITY_INSERT [dbo].[HotelTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (1, CAST(N'2024-05-31T14:41:00.0000000' AS DateTime2), CAST(12275.00 AS Decimal(18, 2)), CAST(2275.00 AS Decimal(18, 2)), CAST(1841.25 AS Decimal(18, 2)), CAST(13.40 AS Decimal(18, 2)), 6)
INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (2, CAST(N'2024-05-31T18:18:00.0000000' AS DateTime2), CAST(24654.00 AS Decimal(18, 2)), CAST(22654.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), 7)
INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (3, CAST(N'2024-05-24T18:20:00.0000000' AS DateTime2), CAST(24654.00 AS Decimal(18, 2)), CAST(2275.00 AS Decimal(18, 2)), CAST(1841.25 AS Decimal(18, 2)), CAST(13.40 AS Decimal(18, 2)), 8)
INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (4, CAST(N'2024-05-31T19:38:00.0000000' AS DateTime2), CAST(52452.00 AS Decimal(18, 2)), CAST(2548.00 AS Decimal(18, 2)), CAST(1841.25 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), 10)
INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (6, CAST(N'2024-05-26T11:03:00.0000000' AS DateTime2), CAST(99999.00 AS Decimal(18, 2)), CAST(2275.00 AS Decimal(18, 2)), CAST(1725.00 AS Decimal(18, 2)), CAST(9.50 AS Decimal(18, 2)), 12)
INSERT [dbo].[Invoice] ([InvoiceID], [InvoiceDate], [TotalAmount], [DiscountAmount], [TaxAmount], [TaxPercentage], [CheckOutID]) VALUES (7, CAST(N'2024-05-30T12:16:00.0000000' AS DateTime2), CAST(53273.00 AS Decimal(18, 2)), CAST(2717.00 AS Decimal(18, 2)), CAST(1399.00 AS Decimal(18, 2)), CAST(3.76 AS Decimal(18, 2)), 14)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomCategoryTbl] ON 

INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (5, N'Presidential Suite', CAST(51475.33 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (7, N'Executive Suite', CAST(45475.66 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (8, N'Junior Suite', CAST(35475.99 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (9, N'Deluxe Double Room', CAST(11475.27 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (10, N'Standard Double Room', CAST(6475.27 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (11, N'Standard Single Room', CAST(2175.35 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (12, N'Premium Villas', CAST(102787.99 AS Decimal(18, 2)), 5)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (13, N'Suite', CAST(51475.33 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (14, N'Presidential Suite', CAST(45475.66 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (15, N'Executive Suite', CAST(35475.99 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (20, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (21, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (22, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (23, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (24, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (25, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (26, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (27, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[RoomCategoryTbl] ([RoomCategoryID], [RoomCategoryName], [BaseCharges], [HotelID]) VALUES (28, NULL, CAST(0.00 AS Decimal(18, 2)), 9)
SET IDENTITY_INSERT [dbo].[RoomCategoryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomPhototTbl] ON 

INSERT [dbo].[RoomPhototTbl] ([RoomPhotoID], [PhotoTitle], [PhotoFilePath], [UploadDate], [RoomID]) VALUES (2, N'p1', N'\RoomPhotos\490836576.jpg', CAST(N'2024-05-16T19:26:00.0000000' AS DateTime2), 3)
SET IDENTITY_INSERT [dbo].[RoomPhototTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomServiceTbl] ON 

INSERT [dbo].[RoomServiceTbl] ([RoomServiceID], [RoomServiceName], [RoomServicePrice], [RoomCategoryID], [HotelID]) VALUES (1, N'Cleaning', CAST(572.00 AS Decimal(18, 2)), 9, 5)
INSERT [dbo].[RoomServiceTbl] ([RoomServiceID], [RoomServiceName], [RoomServicePrice], [RoomCategoryID], [HotelID]) VALUES (2, N'Buffet', CAST(1275.00 AS Decimal(18, 2)), 9, 5)
INSERT [dbo].[RoomServiceTbl] ([RoomServiceID], [RoomServiceName], [RoomServicePrice], [RoomCategoryID], [HotelID]) VALUES (3, N'Cleaning', CAST(1275.00 AS Decimal(18, 2)), 13, 9)
INSERT [dbo].[RoomServiceTbl] ([RoomServiceID], [RoomServiceName], [RoomServicePrice], [RoomCategoryID], [HotelID]) VALUES (4, N'Cleaning', CAST(875.00 AS Decimal(18, 2)), 13, 9)
SET IDENTITY_INSERT [dbo].[RoomServiceTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomTbl] ON 

INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (3, N'SS101', CAST(9275.00 AS Decimal(18, 2)), N'2', N'1', 11, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (4, N'SS102', CAST(9275.00 AS Decimal(18, 2)), N'2', N'1', 11, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (5, N'SS103', CAST(9275.00 AS Decimal(18, 2)), N'2', N'1', 11, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (6, N'SD101', CAST(12275.00 AS Decimal(18, 2)), N'4', N'2', 10, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (7, N'SD102', CAST(12275.00 AS Decimal(18, 2)), N'4', N'2', 10, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (8, N'SD103', CAST(12275.00 AS Decimal(18, 2)), N'4', N'2', 10, 9, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (9, N'DD101', CAST(16275.00 AS Decimal(18, 2)), N'4', N'3', 9, 4, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (10, N'DD102', CAST(16275.00 AS Decimal(18, 2)), N'4', N'3', 9, 4, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (11, N'DD103', CAST(16275.00 AS Decimal(18, 2)), N'4', N'3', 9, 4, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (15, N'PS101', CAST(45272.00 AS Decimal(18, 2)), N'6', N'3', 5, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (16, N'PS102', CAST(45272.00 AS Decimal(18, 2)), N'6', N'3', 5, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (17, N'PS103', CAST(45272.00 AS Decimal(18, 2)), N'6', N'3', 5, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (18, N'ES101', CAST(51272.00 AS Decimal(18, 2)), N'8', N'4', 7, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (19, N'ES102', CAST(51272.00 AS Decimal(18, 2)), N'8', N'4', 7, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (20, N'ES103', CAST(51272.00 AS Decimal(18, 2)), N'8', N'4', 7, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (21, N'JS101', CAST(35272.00 AS Decimal(18, 2)), N'4', N'2', 8, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (22, N'JS102', CAST(35272.00 AS Decimal(18, 2)), N'4', N'2', 8, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (23, N'JS103', CAST(35272.00 AS Decimal(18, 2)), N'4', N'2', 8, 1, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (24, N'PV101', CAST(103272.00 AS Decimal(18, 2)), N'10', N'5', 12, 12, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (25, N'PV102', CAST(103272.00 AS Decimal(18, 2)), N'10', N'5', 12, 12, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (26, N'PV103', CAST(103272.00 AS Decimal(18, 2)), N'10', N'5', 12, 12, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (27, N'CPSR101', CAST(53272.00 AS Decimal(18, 2)), N'6', N'3', 13, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (28, N'CPSR102', CAST(53272.00 AS Decimal(18, 2)), N'6', N'3', 13, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (29, N'CPSR103', CAST(53272.00 AS Decimal(18, 2)), N'6', N'3', 13, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (30, N'CPJS101', CAST(55735.00 AS Decimal(18, 2)), N'8', N'4', 14, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (31, N'CPJS102', CAST(55735.00 AS Decimal(18, 2)), N'8', N'4', 14, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (32, N'CPJS103', CAST(55735.00 AS Decimal(18, 2)), N'8', N'4', 14, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (33, N'CPES101', CAST(65352.00 AS Decimal(18, 2)), N'10', N'5', 15, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (34, N'CPES102', CAST(65352.00 AS Decimal(18, 2)), N'10', N'5', 15, 15, NULL)
INSERT [dbo].[RoomTbl] ([RoomID], [RoomNumber], [RoomCharges], [MaxNoofAdults], [MaxNoofChilds], [RoomCategoryID], [FloorID], [RoomPhotos]) VALUES (35, N'CPES103', CAST(65352.00 AS Decimal(18, 2)), N'10', N'5', 15, 15, NULL)
SET IDENTITY_INSERT [dbo].[RoomTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[StateTbl] ON 

INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (3, N'Maharashtra', 1)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (16, N'Gujrat', 1)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (17, N'Utter Pradesh', 1)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (18, N'Ohio', 2)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (19, N'New York', 2)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (20, N'New Jersey', 2)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (28, N'Capital Chuvash Republic', 3)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (29, N'Republic of Dagestan', 3)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (30, N'Chechen Republic', 3)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (31, N'Bavaria', 4)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (32, N'Saxony', 4)
INSERT [dbo].[StateTbl] ([StateID], [StateName], [CountryID]) VALUES (33, N'Hessen', 4)
SET IDENTITY_INSERT [dbo].[StateTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[TaxTbl] ON 

INSERT [dbo].[TaxTbl] ([TaxID], [TaxPercentage], [HSNSACNo]) VALUES (1, CAST(15.00 AS Decimal(18, 2)), N'526725')
SET IDENTITY_INSERT [dbo].[TaxTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTbl] ON 

INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [UserEmail], [Address], [MobileNo], [Password], [DateofBirth], [Gender], [CityID]) VALUES (2, N'Rushikesh', N'Kadam', N'rskadam1999@gmail.com', N'parbhani', N'8208391176', N'1176', CAST(N'1999-08-03T00:00:00.0000000' AS DateTime2), N'male', 4)
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [UserEmail], [Address], [MobileNo], [Password], [DateofBirth], [Gender], [CityID]) VALUES (8, N'Shivam', N'Ingle', N'sringle@gmail.com', NULL, NULL, N'1176', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 4)
SET IDENTITY_INSERT [dbo].[UserTbl] OFF
GO
ALTER TABLE [dbo].[BookingCheckInTbl] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [DocumentType]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [CheckOutID]
GO
ALTER TABLE [dbo].[BedType]  WITH CHECK ADD  CONSTRAINT [FK_BedType_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[BedType] CHECK CONSTRAINT [FK_BedType_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[BookingCheckInTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookingCheckInTbl_BookingTbl_BookingID] FOREIGN KEY([BookingID])
REFERENCES [dbo].[BookingTbl] ([BookingID])
GO
ALTER TABLE [dbo].[BookingCheckInTbl] CHECK CONSTRAINT [FK_BookingCheckInTbl_BookingTbl_BookingID]
GO
ALTER TABLE [dbo].[BookingCheckOutTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookingCheckOutTbl_BookingTbl_BookingID] FOREIGN KEY([BookingID])
REFERENCES [dbo].[BookingTbl] ([BookingID])
GO
ALTER TABLE [dbo].[BookingCheckOutTbl] CHECK CONSTRAINT [FK_BookingCheckOutTbl_BookingTbl_BookingID]
GO
ALTER TABLE [dbo].[BookingTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookingTbl_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[BookingTbl] CHECK CONSTRAINT [FK_BookingTbl_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[BookingTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookingTbl_UserTbl_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTbl] ([UserID])
GO
ALTER TABLE [dbo].[BookingTbl] CHECK CONSTRAINT [FK_BookingTbl_UserTbl_UserID]
GO
ALTER TABLE [dbo].[BookinRoomTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookinRoomTbl_RoomTbl_RoomID] FOREIGN KEY([RoomID])
REFERENCES [dbo].[RoomTbl] ([RoomID])
GO
ALTER TABLE [dbo].[BookinRoomTbl] CHECK CONSTRAINT [FK_BookinRoomTbl_RoomTbl_RoomID]
GO
ALTER TABLE [dbo].[BookinRoomTbl]  WITH CHECK ADD  CONSTRAINT [FK_BookinRoomTbl_UserTbl_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTbl] ([UserID])
GO
ALTER TABLE [dbo].[BookinRoomTbl] CHECK CONSTRAINT [FK_BookinRoomTbl_UserTbl_UserID]
GO
ALTER TABLE [dbo].[BuildingTbl]  WITH CHECK ADD  CONSTRAINT [FK_BuildingTbl_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[BuildingTbl] CHECK CONSTRAINT [FK_BuildingTbl_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[CancelBookingTbl]  WITH CHECK ADD  CONSTRAINT [FK_CancelBookingTbl_BookingTbl_BookingID] FOREIGN KEY([BookingID])
REFERENCES [dbo].[BookingTbl] ([BookingID])
GO
ALTER TABLE [dbo].[CancelBookingTbl] CHECK CONSTRAINT [FK_CancelBookingTbl_BookingTbl_BookingID]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_CountryTbl_CountryID] FOREIGN KEY([CountryID])
REFERENCES [dbo].[CountryTbl] ([CountryID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_CountryTbl_CountryID]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_StateTbl_StateID] FOREIGN KEY([StateID])
REFERENCES [dbo].[StateTbl] ([StateID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_StateTbl_StateID]
GO
ALTER TABLE [dbo].[FloorTbl]  WITH CHECK ADD  CONSTRAINT [FK_FloorTbl_BuildingTbl_BuildingID] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[BuildingTbl] ([BuildingID])
GO
ALTER TABLE [dbo].[FloorTbl] CHECK CONSTRAINT [FK_FloorTbl_BuildingTbl_BuildingID]
GO
ALTER TABLE [dbo].[HotelRatingTbl]  WITH CHECK ADD  CONSTRAINT [FK_HotelRatingTbl_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[HotelRatingTbl] CHECK CONSTRAINT [FK_HotelRatingTbl_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[HotelRatingTbl]  WITH CHECK ADD  CONSTRAINT [FK_HotelRatingTbl_UserTbl_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTbl] ([UserID])
GO
ALTER TABLE [dbo].[HotelRatingTbl] CHECK CONSTRAINT [FK_HotelRatingTbl_UserTbl_UserID]
GO
ALTER TABLE [dbo].[HotelTbl]  WITH CHECK ADD  CONSTRAINT [FK_HotelTbl_City_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[HotelTbl] CHECK CONSTRAINT [FK_HotelTbl_City_CityID]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_BookingCheckOutTbl_CheckOutID] FOREIGN KEY([CheckOutID])
REFERENCES [dbo].[BookingCheckOutTbl] ([BookingCheckOutID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_BookingCheckOutTbl_CheckOutID]
GO
ALTER TABLE [dbo].[InvoiceTaxTbl]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceTaxTbl_Invoice_InvoiceID] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[InvoiceTaxTbl] CHECK CONSTRAINT [FK_InvoiceTaxTbl_Invoice_InvoiceID]
GO
ALTER TABLE [dbo].[PaymentTbl]  WITH CHECK ADD  CONSTRAINT [FK_PaymentTbl_BookingTbl_BookingID] FOREIGN KEY([BookingID])
REFERENCES [dbo].[BookingTbl] ([BookingID])
GO
ALTER TABLE [dbo].[PaymentTbl] CHECK CONSTRAINT [FK_PaymentTbl_BookingTbl_BookingID]
GO
ALTER TABLE [dbo].[RoomBedTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomBedTbl_BedType_BedTypeID] FOREIGN KEY([BedTypeID])
REFERENCES [dbo].[BedType] ([BedTypeID])
GO
ALTER TABLE [dbo].[RoomBedTbl] CHECK CONSTRAINT [FK_RoomBedTbl_BedType_BedTypeID]
GO
ALTER TABLE [dbo].[RoomCategoryTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomCategoryTbl_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[RoomCategoryTbl] CHECK CONSTRAINT [FK_RoomCategoryTbl_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[RoomPhototTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomPhototTbl_RoomTbl_RoomID] FOREIGN KEY([RoomID])
REFERENCES [dbo].[RoomTbl] ([RoomID])
GO
ALTER TABLE [dbo].[RoomPhototTbl] CHECK CONSTRAINT [FK_RoomPhototTbl_RoomTbl_RoomID]
GO
ALTER TABLE [dbo].[RoomServiceTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomServiceTbl_HotelTbl_HotelID] FOREIGN KEY([HotelID])
REFERENCES [dbo].[HotelTbl] ([HotelID])
GO
ALTER TABLE [dbo].[RoomServiceTbl] CHECK CONSTRAINT [FK_RoomServiceTbl_HotelTbl_HotelID]
GO
ALTER TABLE [dbo].[RoomServiceTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomServiceTbl_RoomCategoryTbl_RoomCategoryID] FOREIGN KEY([RoomCategoryID])
REFERENCES [dbo].[RoomCategoryTbl] ([RoomCategoryID])
GO
ALTER TABLE [dbo].[RoomServiceTbl] CHECK CONSTRAINT [FK_RoomServiceTbl_RoomCategoryTbl_RoomCategoryID]
GO
ALTER TABLE [dbo].[RoomTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomTbl_FloorTbl_FloorID] FOREIGN KEY([FloorID])
REFERENCES [dbo].[FloorTbl] ([FloorID])
GO
ALTER TABLE [dbo].[RoomTbl] CHECK CONSTRAINT [FK_RoomTbl_FloorTbl_FloorID]
GO
ALTER TABLE [dbo].[RoomTbl]  WITH CHECK ADD  CONSTRAINT [FK_RoomTbl_RoomCategoryTbl_RoomCategoryID] FOREIGN KEY([RoomCategoryID])
REFERENCES [dbo].[RoomCategoryTbl] ([RoomCategoryID])
GO
ALTER TABLE [dbo].[RoomTbl] CHECK CONSTRAINT [FK_RoomTbl_RoomCategoryTbl_RoomCategoryID]
GO
ALTER TABLE [dbo].[StateTbl]  WITH CHECK ADD  CONSTRAINT [FK_StateTbl_CountryTbl_CountryID] FOREIGN KEY([CountryID])
REFERENCES [dbo].[CountryTbl] ([CountryID])
GO
ALTER TABLE [dbo].[StateTbl] CHECK CONSTRAINT [FK_StateTbl_CountryTbl_CountryID]
GO
ALTER TABLE [dbo].[UserTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserTbl_City_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[UserTbl] CHECK CONSTRAINT [FK_UserTbl_City_CityID]
GO
