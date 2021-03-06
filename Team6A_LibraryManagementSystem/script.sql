USE [master]
GO
/****** Object:  Database [library]    Script Date: 21/4/2013 12:20:50 PM ******/
CREATE DATABASE [library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\library.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\library_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [library] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [library] SET ARITHABORT OFF 
GO
ALTER DATABASE [library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [library] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [library] SET RECOVERY FULL 
GO
ALTER DATABASE [library] SET  MULTI_USER 
GO
ALTER DATABASE [library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [library] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'library', N'ON'
GO
USE [library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 21/4/2013 12:20:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookModelID] [int] NOT NULL,
	[BookStatus] [smallint] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BooksModels]    Script Date: 21/4/2013 12:20:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BooksModels](
	[BookModelId] [int] IDENTITY(1,1) NOT NULL,
	[BookTitle] [varchar](20) NOT NULL,
	[BookDescription] [varchar](50) NULL,
	[Author] [varchar](15) NOT NULL,
	[PublisherName] [varchar](15) NULL,
	[PublishDate] [date] NULL,
	[BookCategory] [varchar](20) NOT NULL,
	[MaxAvailableDayToRent] [smallint] NULL,
 CONSTRAINT [PK_BooksModels] PRIMARY KEY CLUSTERED 
(
	[BookModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LibTrans]    Script Date: 21/4/2013 12:20:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibTrans](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[LendDate] [date] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[ChargeAmount] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_LibTrans] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Members]    Script Date: 21/4/2013 12:20:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [varchar](20) NOT NULL,
	[Address] [varchar](50) NULL,
	[PhoneNumber] [varchar](10) NOT NULL,
	[NIRC] [varchar](10) NOT NULL,
	[Email] [varchar](20) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [BookModelID], [BookStatus]) VALUES (1, 1, 0)
INSERT [dbo].[Books] ([BookID], [BookModelID], [BookStatus]) VALUES (2, 1, 1)
INSERT [dbo].[Books] ([BookID], [BookModelID], [BookStatus]) VALUES (3, 3, 2)
INSERT [dbo].[Books] ([BookID], [BookModelID], [BookStatus]) VALUES (4, 5, 1)
INSERT [dbo].[Books] ([BookID], [BookModelID], [BookStatus]) VALUES (5, 6, 2)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[BooksModels] ON 

INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (1, N'The Boy', N'Good story about a boy who struggle for life', N'Benson gorge', N'yijum', CAST(0xC61A0B00 AS Date), N'story', 2)
INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (2, N'Dead until Dark', N'A horror story. Night mare', N'Neha', N'sushi', CAST(0x27220B00 AS Date), N'story', 5)
INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (3, N'Tom n Jerry', N'Nice Cartoon character', N'Diana', N'hossim', CAST(0xC2920A00 AS Date), N'comedy', 6)
INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (5, N'Ruby', N'Life Story of a girl', N'Ruby', N'Afan', CAST(0x7A360B00 AS Date), N'tragedy', 7)
INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (6, N'Before Wings', N'Nights in dark related movie', N'Goobie', N'hijy', CAST(0xA1220B00 AS Date), N'tragedy', 5)
INSERT [dbo].[BooksModels] ([BookModelId], [BookTitle], [BookDescription], [Author], [PublisherName], [PublishDate], [BookCategory], [MaxAvailableDayToRent]) VALUES (7, N'Butterfly Lion', N'Animal story ', N'kumar', N'simjon', CAST(0x25160B00 AS Date), N'comedy', 6)
SET IDENTITY_INSERT [dbo].[BooksModels] OFF
SET IDENTITY_INSERT [dbo].[LibTrans] ON 

INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (1, 1, 1, CAST(0x97190B00 AS Date), CAST(0xB5190B00 AS Date), CAST(14 AS Numeric(18, 0)))
INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (2, 2, 6, CAST(0xF6360B00 AS Date), CAST(0x14370B00 AS Date), CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (3, 3, 3, CAST(0x21360B00 AS Date), CAST(0x3F360B00 AS Date), CAST(8 AS Numeric(18, 0)))
INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (4, 5, 1, CAST(0xF3360B00 AS Date), CAST(0x11370B00 AS Date), CAST(10 AS Numeric(18, 0)))
INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (5, 2, 2, CAST(0x94360B00 AS Date), CAST(0x45350B00 AS Date), CAST(20 AS Numeric(18, 0)))
INSERT [dbo].[LibTrans] ([TransactionID], [BookID], [MemberID], [LendDate], [ReturnDate], [ChargeAmount]) VALUES (6, 6, 5, CAST(0xD1360B00 AS Date), CAST(0xF0360B00 AS Date), CAST(7 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[LibTrans] OFF
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (1, N'Abdullah', N'clementi singapore 75', N'77793773', N'1234', N'abdul@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (2, N'Benson', N'jurong singapore 74', N'66577378', N'1235', N'bensy@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (3, N'charlie', N'admiralty singapore', N'68876664', N'1236', N'charly@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (5, N'Dolly', N'kranji singapore 76', N'87667643', N'1237', N'dolly@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (6, N'Eenzi', N'sembawang singapore 78', N'66447878', N'1238', N'eenzi@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (8, N'Rubeena', N'kranji singapore 75', N'75667577', N'1239', N'ruby@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (9, N'Ding Jian', N'admiralty singapore 70', N'88783333', N'1240', N'ding@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (10, N'Ye maw', N'woodlands singapore 78', N'87778822', N'1241', N'yemaw@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (11, N'Nay chi', N'clementi singapore 77', N'68747777', N'1242', N'nay@gmail.com')
INSERT [dbo].[Members] ([MemberID], [MemberName], [Address], [PhoneNumber], [NIRC], [Email]) VALUES (13, N'Neha', N'marsiling singapore 79', N'78848883', N'1243', N'neha@gmail.com')
SET IDENTITY_INSERT [dbo].[Members] OFF
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_BooksModels] FOREIGN KEY([BookModelID])
REFERENCES [dbo].[BooksModels] ([BookModelId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_BooksModels]
GO
USE [master]
GO
ALTER DATABASE [library] SET  READ_WRITE 
GO
