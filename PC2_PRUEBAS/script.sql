-- Crear la base de datos [dbinstituto]
USE [master]
GO
/****** Object:  Database [dbinstituto]    Script Date: 31/10/2023 16:40:26 ******/
CREATE DATABASE [dbinstituto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbinstituto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbinstituto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbinstituto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbinstituto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

-- Establecer el nivel de compatibilidad
ALTER DATABASE [dbinstituto] SET COMPATIBILITY_LEVEL = 150
GO

-- Habilitar el servicio de texto completo si está instalado
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
BEGIN
    EXEC [dbinstituto].[dbo].[sp_fulltext_database] @action = 'enable'
END
GO

-- Configurar varias opciones de base de datos
ALTER DATABASE [dbinstituto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbinstituto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbinstituto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbinstituto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbinstituto] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbinstituto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbinstituto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbinstituto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbinstituto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbinstituto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbinstituto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbinstituto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbinstituto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbinstituto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbinstituto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbinstituto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbinstituto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbinstituto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbinstituto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbinstituto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbinstituto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbinstituto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbinstituto] SET RECOVERY FULL 
GO
ALTER DATABASE [dbinstituto] SET  MULTI_USER 
GO
ALTER DATABASE [dbinstituto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbinstituto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbinstituto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbinstituto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbinstituto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbinstituto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbinstituto', N'ON'
GO
ALTER DATABASE [dbinstituto] SET QUERY_STORE = OFF
GO
USE [dbinstituto]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 31/10/2023 16:40:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id_curso] [int] IDENTITY(1,1) NOT NULL,
	[Nombrecurso] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 31/10/2023 16:40:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docente](
	[Id_docente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Escuela] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocentexCurso]    Script Date: 31/10/2023 16:40:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocentexCurso](
	[Id_docente] [int] NOT NULL,
	[Id_curso] [int] NOT NULL,
	[Semestre] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_docente] ASC,
	[Id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([Id_curso], [Nombrecurso]) VALUES (1, N'Matemáticas')
INSERT [dbo].[Curso] ([Id_curso], [Nombrecurso]) VALUES (2, N'Historia')
INSERT [dbo].[Curso] ([Id_curso], [Nombrecurso]) VALUES (3, N'Ciencias')
INSERT [dbo].[Curso] ([Id_curso], [Nombrecurso]) VALUES (4, N'Literatura')
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (1, N'Luis', N'Ruiz', N'Escuela B')
INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (2, N'Felix', N'Rojas', N'Escuela B')
INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (3, N'Luis', N'Martínez', N'Escuela A')
INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (4, N'María', N'López', N'Escuela C')
INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (9, N'Juana', N'Garay', N'Escuela B')
INSERT [dbo].[Docente] ([Id_docente], [Nombre], [Apellido], [Escuela]) VALUES (10, N'Felix', N'Rojas', N'Escuela B')
SET IDENTITY_INSERT [dbo].[Docente] OFF
GO
INSERT [dbo].[DocentexCurso] ([Id_docente], [Id_curso], [Semestre]) VALUES (1, 1, N'Primavera 2023')
INSERT [dbo].[DocentexCurso] ([Id_docente], [Id_curso], [Semestre]) VALUES (1, 2, N'Primavera 2023')
INSERT [dbo].[DocentexCurso] ([Id_docente], [Id_curso], [Semestre]) VALUES (2, 3, N'Otoño 2023')
INSERT [dbo].[DocentexCurso] ([Id_docente], [Id_curso], [Semestre]) VALUES (3, 1, N'Otoño 2023')
INSERT [dbo].[DocentexCurso] ([Id_docente], [Id_curso], [Semestre]) VALUES (3, 4, N'Otoño 2023')
GO
ALTER TABLE [dbo].[DocentexCurso]  WITH CHECK ADD FOREIGN KEY([Id_curso])
REFERENCES [dbo].[Curso] ([Id_curso])
GO
ALTER TABLE [dbo].[DocentexCurso]  WITH CHECK ADD FOREIGN KEY([Id_docente])
REFERENCES [dbo].[Docente] ([Id_docente])
GO
USE [master]
GO
ALTER DATABASE [dbinstituto] SET  READ_WRITE 
GO
