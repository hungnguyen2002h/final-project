USE [master]
GO

/****** Object:  Database [SHOESTORE]    Script Date: 13/12/2022 8:44:18 CH ******/
DROP DATABASE [SHOESTORE]
GO

/****** Object:  Database [SHOESTORE]    Script Date: 13/12/2022 8:44:18 CH ******/
CREATE DATABASE [SHOESTORE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SHOESTORE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SHOESTORE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SHOESTORE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SHOESTORE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SHOESTORE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SHOESTORE] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SHOESTORE] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SHOESTORE] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SHOESTORE] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SHOESTORE] SET ARITHABORT OFF 
GO

ALTER DATABASE [SHOESTORE] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [SHOESTORE] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SHOESTORE] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SHOESTORE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SHOESTORE] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SHOESTORE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SHOESTORE] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SHOESTORE] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SHOESTORE] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SHOESTORE] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SHOESTORE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SHOESTORE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SHOESTORE] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SHOESTORE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SHOESTORE] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SHOESTORE] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SHOESTORE] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SHOESTORE] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SHOESTORE] SET  MULTI_USER 
GO

ALTER DATABASE [SHOESTORE] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SHOESTORE] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SHOESTORE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SHOESTORE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SHOESTORE] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SHOESTORE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [SHOESTORE] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SHOESTORE] SET  READ_WRITE 
GO


USE [SHOESTORE]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 13/12/2022 8:44:56 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CID] [nchar](10) NOT NULL,
	[CustomerName] [nchar](30) NOT NULL,
	[CustomerGender] [nchar](10) NOT NULL,
	[CustomerPhone] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SHOESTORE]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 13/12/2022 8:45:13 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EID] [nchar](10) NOT NULL,
	[EmployeeName] [nchar](30) NOT NULL,
	[EmployeeUser] [nchar](10) NOT NULL,
	[EmployeePass] [nchar](10) NOT NULL,
	[EmployeeAge] [int] NOT NULL,
	[EmployeeGender] [nchar](10) NOT NULL,
	[EmployeePhone] [nchar](10) NOT NULL,
	[EmployeeAddress] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SHOESTORE]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 13/12/2022 8:45:25 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[IID] [nchar](10) NOT NULL,
	[ENameImportExport] [nchar](40),
	[ProductID] [nchar](10) NOT NULL,
	[Quantity_Import] [int] NULL,
	[Quantity_Export] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[IID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Product1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
GO

ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Product1]
GO

USE [SHOESTORE]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 13/12/2022 8:45:33 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[PID] [nchar](10) NOT NULL,
	[PName] [nchar](30) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SHOESTORE]
GO

/****** Object:  Table [dbo].[Receipt]    Script Date: 14/12/2022 5:53:44 SA ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Receipt](
	[RID] [nchar](10) NOT NULL,
	[CustomerID] [nchar](10) NOT NULL,
	[PID] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[EmployeeID] [nchar](10) NOT NULL,
	[Status] [nchar](10),
	[Payment] [nchar](10),
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CID])
GO

ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Customer]
GO

ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EID])
GO

ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Employee]
GO

ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Product] FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO

ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Product]
GO


USE [SHOESTORE]
GO

INSERT INTO [dbo].[Employee]
           ([EID]
           ,[EmployeeName]
           ,[EmployeeUser]
           ,[EmployeePass]
           ,[EmployeeAge]
           ,[EmployeeGender]
           ,[EmployeePhone]
           ,[EmployeeAddress])
     VALUES
           ('E001',
           'Nguyen Van Hung',
           'hung88',
           'hung88',
           20,
           'Male',
           '0868855280',
           '14, 25A Street')
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Employee]
           ([EID]
           ,[EmployeeName]
           ,[EmployeeUser]
           ,[EmployeePass]
           ,[EmployeeAge]
           ,[EmployeeGender]
           ,[EmployeePhone]
           ,[EmployeeAddress])
     VALUES
           ('E002',
           'Le Van Luc',
           'luc88',
           'luc88',
           20,
           'Male',
           '0327784739',
           'Lam Van Ben Street')
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P001',
           'Dr.Liver Jpanwell',
           35.99,
           100)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P002',
           'NuBest Tall',
           45.99,
           150)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P003',
           'Doctor Plus',
           49.99,
           90)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P004',
           'Melatonin Natrol',
           15.99,
           50)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P005',
           'Cetaphil',
           14.99,
           170)
GO


USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P006',
           'NO2 USA',
           39.99,
           108)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P007',
           'Hepa Nato',
           5.99,
           128)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P008',
           'Eye Vit',
           21.99,
           101)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P009',
           'Milk Thistle Extract',
           69.99,
           125)
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Product]
           ([PID]
           ,[PName]
           ,[UnitPrice]
           ,[Quantity])
     VALUES
           ('P010',
           'Healthy Mega',
           20.99,
           10)
GO


USE [SHOESTORE]
GO

INSERT INTO [dbo].[Customer]
           ([CID]
           ,[CustomerName]
           ,[CustomerGender]
           ,[CustomerPhone])
     VALUES
           ('C001',
           'Smith',
           'Male',
           '0456123789')
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Customer]
           ([CID]
           ,[CustomerName]
           ,[CustomerGender]
           ,[CustomerPhone])
     VALUES
           ('C002',
           'Hana',
           'Female',
           '0369852147')
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Receipt]
           ([RID]
           ,[CustomerID]
           ,[PID]
           ,[Quantity]
           ,[EmployeeID])
     VALUES
           ('R001',
           'C002',
           'P009',
           10,
           'E001')
GO

USE [SHOESTORE]
GO

INSERT INTO [dbo].[Receipt]
           ([RID]
           ,[CustomerID]
           ,[PID]
           ,[Quantity]
           ,[EmployeeID])
     VALUES
           ('R002',
           'C001',
           'P002',
           8,
           'E002')
GO

