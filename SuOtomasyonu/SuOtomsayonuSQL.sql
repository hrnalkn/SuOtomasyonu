USE [master]
GO
/****** Object:  Database [SuOtomasyonu]    Script Date: 29.12.2019 16:20:15 ******/
CREATE DATABASE [SuOtomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuOtomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.HARUNALKAN\MSSQL\DATA\SuOtomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SuOtomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.HARUNALKAN\MSSQL\DATA\SuOtomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SuOtomasyonu] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuOtomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuOtomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuOtomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuOtomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SuOtomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuOtomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SuOtomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [SuOtomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuOtomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuOtomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuOtomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SuOtomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SuOtomasyonu] SET QUERY_STORE = OFF
GO
USE [SuOtomasyonu]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 29.12.2019 16:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 29.12.2019 16:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NOT NULL,
	[Tutar] [int] NOT NULL,
	[Durum] [int] NOT NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Telefon], [Adres]) VALUES (1, N'harun', N'alkan', N'05387859587', N'Gaziosmanpaşa')
INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Telefon], [Adres]) VALUES (2, N'Ahmet', N'Alkan', N'057858458758', N'İkitelli')
INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Telefon], [Adres]) VALUES (3, N'ali', N'veli', N'05987858758', N'Beşiktaş')
INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Telefon], [Adres]) VALUES (7, N'Ahmet', N'Alak', N'548494899849', N'Gaziosmanpaşa')
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Musteriler] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteriler] ([MusteriID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Musteriler]
GO
USE [master]
GO
ALTER DATABASE [SuOtomasyonu] SET  READ_WRITE 
GO
