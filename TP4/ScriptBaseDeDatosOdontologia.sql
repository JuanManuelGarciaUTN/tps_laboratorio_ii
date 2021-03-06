USE [master]
GO

/****** Object:  Database [Odontologia]    Script Date: 19/6/2022 11:57:41 ******/
CREATE DATABASE [Odontologia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Odontologia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Odontologia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Odontologia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Odontologia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Odontologia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Odontologia] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Odontologia] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Odontologia] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Odontologia] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Odontologia] SET ARITHABORT OFF 
GO

ALTER DATABASE [Odontologia] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Odontologia] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Odontologia] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Odontologia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Odontologia] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Odontologia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Odontologia] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Odontologia] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Odontologia] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Odontologia] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Odontologia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Odontologia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Odontologia] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Odontologia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Odontologia] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Odontologia] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Odontologia] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Odontologia] SET RECOVERY FULL 
GO

ALTER DATABASE [Odontologia] SET  MULTI_USER 
GO

ALTER DATABASE [Odontologia] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Odontologia] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Odontologia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Odontologia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Odontologia] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Odontologia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Odontologia] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Odontologia] SET  READ_WRITE 
GO

/****** Object:  Table [dbo].[tablaDeTurnos]    Script Date: 19/6/2022 11:59:12 ******/
USE [Odontologia]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablaDeTurnos](
	[fecha] [bigint] NOT NULL,
	[precio] [real] NOT NULL,
	[tipo] [smallint] NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[fueAtendido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-->A?ado algunos datos para que no este vacia la tabla al inicio del programa
-->Esta hecho a mano, asi que todas las consultas tienen el mismo precio, pero es solo un ejemplo
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206180900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206180930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181000, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181030, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181100, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181130, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181200, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181300, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181330, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181400, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206181430, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206170900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206170930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171030, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171100, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171230, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171300, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171430, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171500, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206171630, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206160900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161030, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161100, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161230, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161300, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161430, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161500, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206161630, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206150900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151030, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151100, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151230, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151300, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151430, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151500, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206151630, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206140900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141100, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141300, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141430, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141500, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206141630, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206130900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131030, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131100, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131230, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131300, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131430, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131500, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206131630, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206120900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206121030, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206121100, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206111230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206111300, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206111430, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206111500, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206111630, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206100900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101030, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101100, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101230, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101300, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101430, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101500, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206101630, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206090900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091100, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091300, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091430, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091500, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206091630, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206080900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081030, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081100, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081230, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081300, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081430, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081500, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206081630, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206070900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071030, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071100, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071300, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071430, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071500, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206071630, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206060900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206060930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206061000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206050930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206050900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206051030, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205181000, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205190930, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205180900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205170930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205160900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205150930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205140900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205130930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205120900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205110930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205100900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2205080930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2204080900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2204070930, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2204070900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2204060930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 1)

INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206200930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206201000, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206201130, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206201200, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206211330, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206221400, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206231530, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206231600, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206240930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206241000, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206241130, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206250900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206251030, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206251100, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206260930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206261000, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206261030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206270900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206270930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206271000, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206280930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206280900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206281030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206290900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206290930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2206291000, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207180930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207180900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207181030, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207010900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207010930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207021000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207020930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207030900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207031030, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207040900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207040930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207051000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207050930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207060900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207061030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207070900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207070930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207081000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207080930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207090900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207091130, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207100900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207100930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207111200, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207110930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207120900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207131230, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207140900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207150930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207161200, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207170930, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207190900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207201330, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207210900, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207220930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207231300, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207240930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207240900, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207251330, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207250900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207260930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207261500, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207270930, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207270900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207281030, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207280900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207290930, 24000, 3, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207291000, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207300930, 24000, 0, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2207300900, 24000, 1, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2208181330, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)
INSERT [dbo].[tablaDeTurnos] ([fecha], [precio], [tipo], [telefono], [nombre], [apellido], [dni], [fueAtendido]) VALUES (2208180900, 24000, 2, 46461048, 'Okabe', 'Rintaro', 10485960, 0)