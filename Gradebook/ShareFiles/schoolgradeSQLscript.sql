USE [master]
GO
/****** Object:  Database [SchoolDatabase]    Script Date: 6/18/2023 2:06:48 PM ******/
CREATE DATABASE [SchoolDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDatabase', FILENAME = N'c:\sql3\SchoolDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolDatabase_log', FILENAME = N'c:\sql3\SchoolDatabase_log.ldf' , SIZE = 504KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SchoolDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolDatabase] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [SchoolDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SchoolDatabase', N'ON'
GO
ALTER DATABASE [SchoolDatabase] SET QUERY_STORE = OFF
GO
USE [SchoolDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[administratorID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[recordID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[administratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[courseID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[prefix] [varchar](3) NOT NULL,
	[number] [varchar](4) NOT NULL,
	[section] [int] NOT NULL,
	[credithours] [int] NOT NULL,
	[semester] [varchar](8) NOT NULL,
	[year] [int] NOT NULL,
	[teacherID] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[courseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[recordID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[street] [varchar](100) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [char](2) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
	[sex] [char](1) NOT NULL,
	[ssn] [char](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[recordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[studentID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[recordID] [int] NOT NULL,
	[activeStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentsInCourse]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsInCourse](
	[courseID] [int] NOT NULL,
	[studentID] [int] NOT NULL,
 CONSTRAINT [PK_StudentsInCourse] PRIMARY KEY CLUSTERED 
(
	[courseID] ASC,
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 6/18/2023 2:06:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[teacherID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[recordID] [int] NOT NULL,
	[activeStatus] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[teacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [password]) VALUES (N'admin001', N'BDEr9bCKzkeMPeJ9My75h7VpO4a9j811qteQxn+HSN/JQo0KAUvWiroIagyuIsnL50bW3PNax9PuKg8eNBkeIQ==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N's_ltan1', N'wAGSX8dysqHCpub8/Nt7Jb61vqREfOdwXw9SOvXAn0HksntgKqnB7+hbaT+1c77DsYDAQukrqTFc7/jpYF99qg==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N'sjones1', N'sQnzu7wkTrgkQZF+0G1hi5AI3Qmzvv0bXgc5THBqi7mAsdd4Xll27ASbRt9fEyavWi6m0QP9B8lThf+rDKy8hg==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N'ssmith1', N'sQnzu7wkTrgkQZF+0G1hi5AI3Qmzvv0bXgc5THBqi7mAsdd4Xll27ASbRt9fEyavWi6m0QP9B8lThf+rDKy8hg==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N'tjones1', N'sQnzu7wkTrgkQZF+0G1hi5AI3Qmzvv0bXgc5THBqi7mAsdd4Xll27ASbRt9fEyavWi6m0QP9B8lThf+rDKy8hg==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N'tsmith1', N'sQnzu7wkTrgkQZF+0G1hi5AI3Qmzvv0bXgc5THBqi7mAsdd4Xll27ASbRt9fEyavWi6m0QP9B8lThf+rDKy8hg==')
INSERT [dbo].[Account] ([username], [password]) VALUES (N'username', N'sQnzu7wkTrgkQZF+0G1hi5AI3Qmzvv0bXgc5THBqi7mAsdd4Xll27ASbRt9fEyavWi6m0QP9B8lThf+rDKy8hg==')
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([administratorID], [username], [recordID]) VALUES (1, N'username', 1)
INSERT [dbo].[Administrator] ([administratorID], [username], [recordID]) VALUES (2, N'admin001', 2)
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (1, N'English 101', N'ENG', N'1101', 1, 3, N'Spring', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (2, N'Chemistry 101', N'CHM', N'1101', 1, 3, N'Spring', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (3, N'Computer Science 101', N'CS', N'1001', 1, 3, N'Spring', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (4, N'English 102', N'ENG', N'1102', 1, 3, N'Summer', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (5, N'Chemistry 102', N'CHM', N'1102', 1, 3, N'Summer', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (6, N'Computer Science 102', N'CS', N'1102', 1, 3, N'Summer', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (7, N'English 103', N'ENG', N'1103', 1, 3, N'Fall', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (8, N'Chemistry 103', N'CHM', N'1103', 1, 3, N'Fall', 2023, NULL)
INSERT [dbo].[Course] ([courseID], [name], [prefix], [number], [section], [credithours], [semester], [year], [teacherID]) VALUES (9, N'Computer Science', N'CS', N'1103', 1, 3, N'Fall', 2023, NULL)
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (1, N'Smith', N'Admin', CAST(N'1952-01-01' AS Date), N'123 That Street', N'Atlanta', N'GA', N'12345', N'1231231234', N'M', N'123451212')
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (2, N'Jones', N'Admin', CAST(N'1975-02-02' AS Date), N'321 Another St', N'Snellville', N'GA', N'54321', N'1231234321', N'F', NULL)
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (3, N'Smith', N'Teacher', CAST(N'1975-03-03' AS Date), N'123 Some Street', N'Atlanta', N'GA', N'12345', N'1231231234', N'M', NULL)
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (4, N'Jones', N'Teacher', CAST(N'1975-04-04' AS Date), N'99 My Street', N'Somewhere', N'NY', N'12345', N'1232344566', N'F', NULL)
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (5, N'Smith', N'Student', CAST(N'1999-05-05' AS Date), N'123 An Address', N'Another', N'CA', N'11111', N'1112223333', N'M', NULL)
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (6, N'Jones', N'Student', CAST(N'1999-06-06' AS Date), N'321 An Address', N'Another', N'CA', N'11111', N'1112223333', N'F', NULL)
INSERT [dbo].[Person] ([recordID], [lastName], [firstName], [birthday], [street], [city], [state], [zip], [phoneNumber], [sex], [ssn]) VALUES (7, N'tan', N'leo', CAST(N'2013-06-17' AS Date), N'12345', N'12345', N'ME', N'88888', N'5555555553', N'F', N'888888888')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([studentID], [username], [recordID], [activeStatus]) VALUES (1, N'ssmith1', 5, 1)
INSERT [dbo].[Student] ([studentID], [username], [recordID], [activeStatus]) VALUES (2, N'sjones1', 6, 1)
INSERT [dbo].[Student] ([studentID], [username], [recordID], [activeStatus]) VALUES (3, N's_ltan1', 7, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([teacherID], [username], [recordID], [activeStatus]) VALUES (2, N'tsmith1', 3, 1)
INSERT [dbo].[Teacher] ([teacherID], [username], [recordID], [activeStatus]) VALUES (3, N'tjones1', 4, 1)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_To_Account] FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_To_Account]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_To_Person] FOREIGN KEY([recordID])
REFERENCES [dbo].[Person] ([recordID])
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_To_Person]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_To_Teacher] FOREIGN KEY([teacherID])
REFERENCES [dbo].[Teacher] ([teacherID])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_To_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_To_Account] FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_To_Account]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_To_Person] FOREIGN KEY([recordID])
REFERENCES [dbo].[Person] ([recordID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_To_Person]
GO
ALTER TABLE [dbo].[StudentsInCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentsInCourse_To_Course] FOREIGN KEY([courseID])
REFERENCES [dbo].[Course] ([courseID])
GO
ALTER TABLE [dbo].[StudentsInCourse] CHECK CONSTRAINT [FK_StudentsInCourse_To_Course]
GO
ALTER TABLE [dbo].[StudentsInCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentsInCourse_To_Student] FOREIGN KEY([studentID])
REFERENCES [dbo].[Student] ([studentID])
GO
ALTER TABLE [dbo].[StudentsInCourse] CHECK CONSTRAINT [FK_StudentsInCourse_To_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_To_Account] FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_To_Account]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_To_Person] FOREIGN KEY([recordID])
REFERENCES [dbo].[Person] ([recordID])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_To_Person]
GO
USE [master]
GO
ALTER DATABASE [SchoolDatabase] SET  READ_WRITE 
GO
