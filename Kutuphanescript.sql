USE [master]
GO

/****** Object:  Database [kutuphane]    Script Date: 19.01.2023 21:52:49 ******/
CREATE DATABASE [kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\kutuphane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [kutuphane] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [kutuphane] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [kutuphane] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [kutuphane] SET ARITHABORT OFF 
GO

ALTER DATABASE [kutuphane] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [kutuphane] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [kutuphane] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [kutuphane] SET  ENABLE_BROKER 
GO

ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [kutuphane] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [kutuphane] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [kutuphane] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [kutuphane] SET  MULTI_USER 
GO

ALTER DATABASE [kutuphane] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [kutuphane] SET DB_CHAINING OFF 
GO

ALTER DATABASE [kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [kutuphane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [kutuphane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [kutuphane] SET QUERY_STORE = OFF
GO

ALTER DATABASE [kutuphane] SET  READ_WRITE 
GO


