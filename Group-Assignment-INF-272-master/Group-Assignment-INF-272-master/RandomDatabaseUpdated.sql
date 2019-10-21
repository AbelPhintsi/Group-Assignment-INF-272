USE [master]
GO
/****** Object:  Database [DatabaseRandom]    Script Date: 2019/10/18 00:26:54 ******/
CREATE DATABASE [DatabaseRandom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DatabaseRandom', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DatabaseRandom.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DatabaseRandom_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DatabaseRandom_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DatabaseRandom] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DatabaseRandom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DatabaseRandom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DatabaseRandom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DatabaseRandom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DatabaseRandom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DatabaseRandom] SET ARITHABORT OFF 
GO
ALTER DATABASE [DatabaseRandom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DatabaseRandom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DatabaseRandom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DatabaseRandom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DatabaseRandom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DatabaseRandom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DatabaseRandom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DatabaseRandom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DatabaseRandom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DatabaseRandom] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DatabaseRandom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DatabaseRandom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DatabaseRandom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DatabaseRandom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DatabaseRandom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DatabaseRandom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DatabaseRandom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DatabaseRandom] SET RECOVERY FULL 
GO
ALTER DATABASE [DatabaseRandom] SET  MULTI_USER 
GO
ALTER DATABASE [DatabaseRandom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DatabaseRandom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DatabaseRandom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DatabaseRandom] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DatabaseRandom] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DatabaseRandom', N'ON'
GO
USE [DatabaseRandom]
GO
/****** Object:  Table [dbo].[ADMINISTRATOR]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADMINISTRATOR](
	[AdministratorID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
	[DateEmployed] [datetime] NOT NULL,
	[Active] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ADMINISTRATOR] PRIMARY KEY CLUSTERED 
(
	[AdministratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CITY]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CITY](
	[CityID] [int] NOT NULL,
	[RegionID] [int] NOT NULL,
	[CityName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CITY] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COUNTRY]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COUNTRY](
	[CountryID] [int] NOT NULL,
	[CountryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_COUNTRY] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[DepartmentID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_DEPARTMENT] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GRADE]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GRADE](
	[GradeID] [int] NOT NULL,
	[LevelID] [int] NOT NULL,
	[GradeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GRADE] PRIMARY KEY CLUSTERED 
(
	[GradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INSTITUTION]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INSTITUTION](
	[InstitutionID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_INSTITUTION] PRIMARY KEY CLUSTERED 
(
	[InstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LEVEL]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LEVEL](
	[LevelID] [int] NOT NULL,
	[LevelName] [varchar](50) NOT NULL,
	[LevelMode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LEVEL] PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REGION]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REGION](
	[RegionID] [int] NOT NULL,
	[CountryID] [int] NOT NULL,
	[RegionName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_REGION] PRIMARY KEY CLUSTERED 
(
	[RegionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STUDENT]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STUDENT](
	[StudentID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_STUDENT] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUBJECT]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUBJECT](
	[SubjectID] [int] NOT NULL,
	[GradeID] [int] NOT NULL,
	[SubjectName] [varchar](50) NOT NULL,
	[SubjectDescription] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SUBJECT] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUBJECTFACT]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUBJECTFACT](
	[SubjectFactID] [varchar](50) NOT NULL,
	[SubjectID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[HistoryFact] [varchar](50) NOT NULL,
	[GeneralFact] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SUBJECTFACT] PRIMARY KEY CLUSTERED 
(
	[SubjectFactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TEST]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEST](
	[TestID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[DateStarted] [datetime] NOT NULL,
	[DateCompleted] [datetime] NOT NULL,
 CONSTRAINT [PK_TEST] PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TestStudent]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestStudent](
	[ID] [int] NOT NULL,
	[TestID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[Mark] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_TestStudent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THEME]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THEME](
	[ThemeID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[ThemeMode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_THEME] PRIMARY KEY CLUSTERED 
(
	[ThemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USER]    Script Date: 2019/10/18 00:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserEmail] [varchar](50) NOT NULL,
	[UserPassword] [varchar](50) NOT NULL,
	[GUID] [varchar](50) NOT NULL,
	[GUIDExpiry] [datetime] NOT NULL,
	[AdministratorID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CITY]  WITH CHECK ADD  CONSTRAINT [FK_CITY_REGION] FOREIGN KEY([RegionID])
REFERENCES [dbo].[REGION] ([RegionID])
GO
ALTER TABLE [dbo].[CITY] CHECK CONSTRAINT [FK_CITY_REGION]
GO
ALTER TABLE [dbo].[DEPARTMENT]  WITH CHECK ADD  CONSTRAINT [FK_DEPARTMENT_SUBJECT] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[SUBJECT] ([SubjectID])
GO
ALTER TABLE [dbo].[DEPARTMENT] CHECK CONSTRAINT [FK_DEPARTMENT_SUBJECT]
GO
ALTER TABLE [dbo].[GRADE]  WITH CHECK ADD  CONSTRAINT [FK_GRADE_LEVEL] FOREIGN KEY([LevelID])
REFERENCES [dbo].[LEVEL] ([LevelID])
GO
ALTER TABLE [dbo].[GRADE] CHECK CONSTRAINT [FK_GRADE_LEVEL]
GO
ALTER TABLE [dbo].[INSTITUTION]  WITH CHECK ADD  CONSTRAINT [FK_INSTITUTION_CITY] FOREIGN KEY([CityID])
REFERENCES [dbo].[CITY] ([CityID])
GO
ALTER TABLE [dbo].[INSTITUTION] CHECK CONSTRAINT [FK_INSTITUTION_CITY]
GO
ALTER TABLE [dbo].[REGION]  WITH CHECK ADD  CONSTRAINT [FK_REGION_COUNTRY] FOREIGN KEY([CountryID])
REFERENCES [dbo].[COUNTRY] ([CountryID])
GO
ALTER TABLE [dbo].[REGION] CHECK CONSTRAINT [FK_REGION_COUNTRY]
GO
ALTER TABLE [dbo].[STUDENT]  WITH CHECK ADD  CONSTRAINT [FK_STUDENT_COUNTRY] FOREIGN KEY([CountryID])
REFERENCES [dbo].[COUNTRY] ([CountryID])
GO
ALTER TABLE [dbo].[STUDENT] CHECK CONSTRAINT [FK_STUDENT_COUNTRY]
GO
ALTER TABLE [dbo].[SUBJECT]  WITH CHECK ADD  CONSTRAINT [FK_SUBJECT_GRADE] FOREIGN KEY([GradeID])
REFERENCES [dbo].[GRADE] ([GradeID])
GO
ALTER TABLE [dbo].[SUBJECT] CHECK CONSTRAINT [FK_SUBJECT_GRADE]
GO
ALTER TABLE [dbo].[SUBJECTFACT]  WITH CHECK ADD  CONSTRAINT [FK_SUBJECTFACT_SUBJECT] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[SUBJECT] ([SubjectID])
GO
ALTER TABLE [dbo].[SUBJECTFACT] CHECK CONSTRAINT [FK_SUBJECTFACT_SUBJECT]
GO
ALTER TABLE [dbo].[TEST]  WITH CHECK ADD  CONSTRAINT [FK_TEST_SUBJECT] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[SUBJECT] ([SubjectID])
GO
ALTER TABLE [dbo].[TEST] CHECK CONSTRAINT [FK_TEST_SUBJECT]
GO
ALTER TABLE [dbo].[TestStudent]  WITH CHECK ADD  CONSTRAINT [FK_TestStudent_STUDENT] FOREIGN KEY([StudentID])
REFERENCES [dbo].[STUDENT] ([StudentID])
GO
ALTER TABLE [dbo].[TestStudent] CHECK CONSTRAINT [FK_TestStudent_STUDENT]
GO
ALTER TABLE [dbo].[TestStudent]  WITH CHECK ADD  CONSTRAINT [FK_TestStudent_TEST] FOREIGN KEY([TestID])
REFERENCES [dbo].[TEST] ([TestID])
GO
ALTER TABLE [dbo].[TestStudent] CHECK CONSTRAINT [FK_TestStudent_TEST]
GO
ALTER TABLE [dbo].[THEME]  WITH CHECK ADD  CONSTRAINT [FK_THEME_SUBJECT] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[SUBJECT] ([SubjectID])
GO
ALTER TABLE [dbo].[THEME] CHECK CONSTRAINT [FK_THEME_SUBJECT]
GO
ALTER TABLE [dbo].[USER]  WITH CHECK ADD  CONSTRAINT [FK_USER_ADMINISTRATOR] FOREIGN KEY([AdministratorID])
REFERENCES [dbo].[ADMINISTRATOR] ([AdministratorID])
GO
ALTER TABLE [dbo].[USER] CHECK CONSTRAINT [FK_USER_ADMINISTRATOR]
GO
ALTER TABLE [dbo].[USER]  WITH CHECK ADD  CONSTRAINT [FK_USER_STUDENT] FOREIGN KEY([StudentID])
REFERENCES [dbo].[STUDENT] ([StudentID])
GO
ALTER TABLE [dbo].[USER] CHECK CONSTRAINT [FK_USER_STUDENT]
GO
USE [master]
GO
ALTER DATABASE [DatabaseRandom] SET  READ_WRITE 
GO
