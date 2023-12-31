USE [master]
GO
/****** Object:  Database [YogaCenter]    Script Date: 12/07/2023 12:49:23 ******/
CREATE DATABASE [YogaCenter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YogaCenter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\YogaCenter.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YogaCenter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\YogaCenter_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YogaCenter] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YogaCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YogaCenter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YogaCenter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YogaCenter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YogaCenter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YogaCenter] SET ARITHABORT OFF 
GO
ALTER DATABASE [YogaCenter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YogaCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YogaCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YogaCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YogaCenter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YogaCenter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YogaCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YogaCenter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YogaCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YogaCenter] SET  ENABLE_BROKER 
GO
ALTER DATABASE [YogaCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YogaCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YogaCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YogaCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YogaCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YogaCenter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YogaCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YogaCenter] SET RECOVERY FULL 
GO
ALTER DATABASE [YogaCenter] SET  MULTI_USER 
GO
ALTER DATABASE [YogaCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YogaCenter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YogaCenter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YogaCenter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YogaCenter] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YogaCenter] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'YogaCenter', N'ON'
GO
ALTER DATABASE [YogaCenter] SET QUERY_STORE = OFF
GO
USE [YogaCenter]
GO
/****** Object:  Table [dbo].[attendance]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendance](
	[lesson_id] [int] NOT NULL,
	[learner_id] [bigint] NOT NULL,
 CONSTRAINT [PK_attendance] PRIMARY KEY CLUSTERED 
(
	[lesson_id] ASC,
	[learner_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[course]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[program_id] [int] NULL,
	[course_number] [smallint] NULL,
	[instructor_id] [bigint] NULL,
	[start_date] [date] NULL,
	[end_date] [date] NULL,
	[schedule] [nvarchar](200) NULL,
	[registration_open_date] [date] NULL,
	[registration_close_date] [date] NULL,
	[inactive] [bit] NOT NULL,
 CONSTRAINT [PK_course] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[courseregister]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courseregister](
	[course_id] [int] NOT NULL,
	[learner_id] [bigint] NOT NULL,
 CONSTRAINT [PK_courseregister] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[learner_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lesson]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lesson](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[program_id] [int] NULL,
	[course_number] [smallint] NULL,
	[lesson_number] [tinyint] NULL,
	[description] [nvarchar](1000) NULL,
	[date] [date] NULL,
	[location] [nvarchar](20) NULL,
	[timeslot] [tinyint] NULL,
	[inactive] [bit] NOT NULL,
 CONSTRAINT [PK_lesson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[program]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[program](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](4000) NULL,
	[fee] [money] NULL,
	[rating] [tinyint] NULL,
	[img] [varchar](256) NULL,
	[inactive] [bit] NOT NULL,
 CONSTRAINT [PK_program] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[program_instructor]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[program_instructor](
	[program_id] [int] NOT NULL,
	[instructor_id] [bigint] NOT NULL,
 CONSTRAINT [PK_program_instructor] PRIMARY KEY CLUSTERED 
(
	[program_id] ASC,
	[instructor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[review]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[review](
	[id] [bigint] NOT NULL,
	[program_id] [int] NULL,
	[learner_id] [bigint] NULL,
	[content] [nvarchar](1000) NULL,
 CONSTRAINT [PK_review] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](15) NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[timeslot]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[timeslot](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
 CONSTRAINT [PK_timeslot] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 12/07/2023 12:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[username] [varchar](200) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[join_date] [datetime] NULL,
	[last_login] [datetime] NULL,
	[role_id] [tinyint] NOT NULL,
	[code] [varchar](10) NULL,
	[fullname] [nvarchar](200) NULL,
	[dob] [date] NULL,
	[gender] [tinyint] NULL,
	[email] [nvarchar](200) NULL,
	[phone] [nvarchar](15) NULL,
	[img] [varchar](256) NULL,
	[study_goals] [nvarchar](200) NULL,
	[specializations] [nvarchar](200) NULL,
	[experience] [nvarchar](200) NULL,
	[inactive] [bit] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[course] ON 

INSERT [dbo].[course] ([id], [program_id], [course_number], [instructor_id], [start_date], [end_date], [schedule], [registration_open_date], [registration_close_date], [inactive]) VALUES (1, 1, 102, NULL, CAST(N'2023-08-01' AS Date), CAST(N'2023-08-30' AS Date), N'Monday - Wednesday - Friday', CAST(N'2023-07-15' AS Date), CAST(N'2023-07-31' AS Date), 0)
INSERT [dbo].[course] ([id], [program_id], [course_number], [instructor_id], [start_date], [end_date], [schedule], [registration_open_date], [registration_close_date], [inactive]) VALUES (2, 2, 101, 3, CAST(N'2023-09-01' AS Date), CAST(N'2023-09-30' AS Date), N'Tuesday - Thursday', CAST(N'2023-08-15' AS Date), CAST(N'2023-08-31' AS Date), 0)
SET IDENTITY_INSERT [dbo].[course] OFF
GO
SET IDENTITY_INSERT [dbo].[lesson] ON 

INSERT [dbo].[lesson] ([id], [program_id], [course_number], [lesson_number], [description], [date], [location], [timeslot], [inactive]) VALUES (1, 1, 102, 1, N'Introduction to Yoga', CAST(N'2023-08-01' AS Date), N'Studio A', 1, 0)
INSERT [dbo].[lesson] ([id], [program_id], [course_number], [lesson_number], [description], [date], [location], [timeslot], [inactive]) VALUES (2, 2, 101, 2, N'Basic Yoga Poses', CAST(N'2023-08-03' AS Date), N'Studio A', 2, 0)
SET IDENTITY_INSERT [dbo].[lesson] OFF
GO
SET IDENTITY_INSERT [dbo].[program] ON 

INSERT [dbo].[program] ([id], [description], [fee], [rating], [img], [inactive]) VALUES (1, N'Beginners Yoga Program', 100.0000, 4, NULL, 0)
INSERT [dbo].[program] ([id], [description], [fee], [rating], [img], [inactive]) VALUES (2, N'Advanced Yoga Program', 150.0000, 5, NULL, 0)
SET IDENTITY_INSERT [dbo].[program] OFF
GO
SET IDENTITY_INSERT [dbo].[role] ON 

INSERT [dbo].[role] ([id], [name]) VALUES (1, N'ADMIN')
INSERT [dbo].[role] ([id], [name]) VALUES (2, N'LEARNER')
INSERT [dbo].[role] ([id], [name]) VALUES (3, N'INSTRUCTOR')
SET IDENTITY_INSERT [dbo].[role] OFF
GO
SET IDENTITY_INSERT [dbo].[timeslot] ON 

INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (1, N'Morning', CAST(N'09:00:00' AS Time), CAST(N'11:00:00' AS Time))
INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (2, N'Afternoon', CAST(N'14:00:00' AS Time), CAST(N'16:00:00' AS Time))
INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (3, N'Morning', CAST(N'09:00:00' AS Time), CAST(N'11:00:00' AS Time))
INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (4, N'Afternoon', CAST(N'14:00:00' AS Time), CAST(N'16:00:00' AS Time))
INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (5, N'Morning', CAST(N'09:00:00' AS Time), CAST(N'11:00:00' AS Time))
INSERT [dbo].[timeslot] ([id], [name], [start_time], [end_time]) VALUES (6, N'Afternoon', CAST(N'14:00:00' AS Time), CAST(N'16:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[timeslot] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (1, N'john123', N'password123', CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-07-01T00:00:00.000' AS DateTime), 1, N'ABC123', N'John Doe', CAST(N'1990-05-15' AS Date), 1, N'john.doe@example.com', N'1234567890', NULL, N'Yoga for relaxation', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (2, N'jane456', N'password456', CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-07-02T00:00:00.000' AS DateTime), 2, N'DEF456', N'Jane Smith', CAST(N'1995-08-20' AS Date), 2, N'jane.smith@example.com', N'9876543210', NULL, N'Yoga for flexibility', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (3, N'user3', N'password3', CAST(N'2023-03-01T00:00:00.000' AS DateTime), NULL, 2, N'GHI789', N'User Three', CAST(N'1992-03-10' AS Date), 1, N'user3@example.com', N'5555555555', NULL, N'Yoga for strength', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (4, N'user4', N'password4', CAST(N'2023-04-01T00:00:00.000' AS DateTime), NULL, 2, N'JKL012', N'User Four', CAST(N'1994-07-22' AS Date), 2, N'user4@example.com', N'5555555555', NULL, N'Yoga for relaxation', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (5, N'user5', N'password5', CAST(N'2023-05-01T00:00:00.000' AS DateTime), NULL, 2, N'MNO345', N'User Five', CAST(N'1991-12-05' AS Date), 1, N'user5@example.com', N'5555555555', NULL, N'Yoga for flexibility', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (6, N'user6', N'password6', CAST(N'2023-06-01T00:00:00.000' AS DateTime), NULL, 2, N'PQR678', N'User Six', CAST(N'1989-02-15' AS Date), 2, N'user6@example.com', N'5555555555', NULL, N'Yoga for strength', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (7, N'user7', N'password7', CAST(N'2023-07-01T00:00:00.000' AS DateTime), NULL, 2, N'STU901', N'User Seven', CAST(N'1993-06-30' AS Date), 1, N'user7@example.com', N'5555555555', NULL, N'Yoga for relaxation', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (8, N'user8', N'password8', CAST(N'2023-08-01T00:00:00.000' AS DateTime), NULL, 2, N'VWX234', N'User Eight', CAST(N'1990-11-18' AS Date), 2, N'user8@example.com', N'5555555555', NULL, N'Yoga for flexibility', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (9, N'user9', N'password9', CAST(N'2023-09-01T00:00:00.000' AS DateTime), NULL, 2, N'YZA567', N'User Nine', CAST(N'1987-04-25' AS Date), 1, N'user9@example.com', N'5555555555', NULL, N'Yoga for strength', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (10, N'user10', N'password10', CAST(N'2023-10-01T00:00:00.000' AS DateTime), NULL, 2, N'BCD890', N'User Ten', CAST(N'1995-09-12' AS Date), 2, N'user10@example.com', N'5555555555', NULL, N'Yoga for relaxation', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (11, N'user11', N'password11', CAST(N'2023-11-01T00:00:00.000' AS DateTime), NULL, 2, N'EFG123', N'User Eleven', CAST(N'1992-01-07' AS Date), 1, N'user11@example.com', N'5555555555', NULL, N'Yoga for flexibility', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (12, N'user12', N'password12', CAST(N'2023-12-01T00:00:00.000' AS DateTime), NULL, 2, N'HIJ456', N'User Twelve', CAST(N'1988-03-23' AS Date), 2, N'user12@example.com', N'5555555555', NULL, N'Yoga for strength', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (13, N'user13', N'password13', CAST(N'2024-01-01T00:00:00.000' AS DateTime), NULL, 2, N'KLM789', N'User Thirteen', CAST(N'1994-06-09' AS Date), 1, N'user13@example.com', N'5555555555', NULL, N'Yoga for relaxation', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (14, N'user14', N'password14', CAST(N'2024-02-01T00:00:00.000' AS DateTime), NULL, 2, N'NOP012', N'User Fourteen', CAST(N'1991-09-27' AS Date), 2, N'user14@example.com', N'5555555555', NULL, N'Yoga for flexibility', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (15, N'user15', N'password15', CAST(N'2024-03-01T00:00:00.000' AS DateTime), NULL, 2, N'QRS345', N'User Fifteen', CAST(N'1985-12-10' AS Date), 1, N'user15@example.com', N'5555555555', NULL, N'Yoga for strength', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (16, N'admin', N'adminpassword', CAST(N'2023-07-11T21:43:55.957' AS DateTime), CAST(N'2023-07-11T21:43:55.957' AS DateTime), 1, NULL, N'Admin User', CAST(N'1990-01-01' AS Date), 1, N'admin@example.com', N'1234567890', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (17, N'learner1', N'learnerpassword', CAST(N'2023-07-11T21:43:55.957' AS DateTime), CAST(N'2023-07-11T21:43:55.957' AS DateTime), 2, N'L001', N'Learner 1', CAST(N'1995-05-10' AS Date), 2, N'learner1@example.com', N'9876543210', NULL, N'Improve flexibility and reduce stress', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (18, N'instructor1', N'instructorpassword', CAST(N'2023-07-11T21:43:55.957' AS DateTime), CAST(N'2023-07-11T21:43:55.957' AS DateTime), 3, N'I001', N'Instructor 1', CAST(N'1988-09-20' AS Date), 1, N'instructor1@example.com', N'5555555555', NULL, NULL, N'Hatha Yoga', N'5 years of teaching experience', 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (19, N'admin', N'adminpassword', CAST(N'2023-07-11T21:47:50.143' AS DateTime), CAST(N'2023-07-11T21:47:50.143' AS DateTime), 1, NULL, N'Admin User', CAST(N'1990-01-01' AS Date), 1, N'admin@example.com', N'1234567890', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (20, N'learner1', N'learnerpassword', CAST(N'2023-07-11T21:47:50.143' AS DateTime), CAST(N'2023-07-11T21:47:50.143' AS DateTime), 2, N'L001', N'Learner 1', CAST(N'1995-05-10' AS Date), 2, N'learner1@example.com', N'9876543210', NULL, N'Improve flexibility and reduce stress', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (21, N'instructor1', N'instructorpassword', CAST(N'2023-07-11T21:47:50.143' AS DateTime), CAST(N'2023-07-11T21:47:50.143' AS DateTime), 3, N'I001', N'Instructor 1', CAST(N'1988-09-20' AS Date), 1, N'instructor1@example.com', N'5555555555', NULL, NULL, N'Hatha Yoga', N'5 years of teaching experience', 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (22, N'admin', N'adminpassword', CAST(N'2023-07-11T21:50:54.433' AS DateTime), CAST(N'2023-07-11T21:50:54.433' AS DateTime), 1, NULL, N'Admin User', CAST(N'1990-01-01' AS Date), 1, N'admin@example.com', N'1234567890', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (23, N'learner1', N'learnerpassword', CAST(N'2023-07-11T21:50:54.433' AS DateTime), CAST(N'2023-07-11T21:50:54.433' AS DateTime), 2, N'L001', N'Learner 1', CAST(N'1995-05-10' AS Date), 2, N'learner1@example.com', N'9876543210', NULL, N'Improve flexibility and reduce stress', NULL, NULL, 0)
INSERT [dbo].[user] ([id], [username], [password], [join_date], [last_login], [role_id], [code], [fullname], [dob], [gender], [email], [phone], [img], [study_goals], [specializations], [experience], [inactive]) VALUES (24, N'instructor1', N'instructorpassword', CAST(N'2023-07-11T21:50:54.433' AS DateTime), CAST(N'2023-07-11T21:50:54.433' AS DateTime), 3, N'I001', N'Instructor 1', CAST(N'1988-09-20' AS Date), 1, N'instructor1@example.com', N'5555555555', NULL, NULL, N'Hatha Yoga', N'5 years of teaching experience', 0)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
/****** Object:  Index [IX_course_program_id_course_number]    Script Date: 12/07/2023 12:49:23 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_course_program_id_course_number] ON [dbo].[course]
(
	[program_id] ASC,
	[course_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_lesson_course_id_course_number_lesson_number]    Script Date: 12/07/2023 12:49:23 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_lesson_course_id_course_number_lesson_number] ON [dbo].[lesson]
(
	[program_id] ASC,
	[course_number] ASC,
	[lesson_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[course] ADD  CONSTRAINT [DF_course_inactive]  DEFAULT ((0)) FOR [inactive]
GO
ALTER TABLE [dbo].[lesson] ADD  CONSTRAINT [DF_lesson_inactive]  DEFAULT ((0)) FOR [inactive]
GO
ALTER TABLE [dbo].[program] ADD  CONSTRAINT [DF_program_inactive]  DEFAULT ((0)) FOR [inactive]
GO
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_role_id]  DEFAULT ((1)) FOR [role_id]
GO
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_inactive]  DEFAULT ((0)) FOR [inactive]
GO
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [FK_attendance_lesson_lesson_id] FOREIGN KEY([lesson_id])
REFERENCES [dbo].[lesson] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [FK_attendance_lesson_lesson_id]
GO
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [FK_attendance_user_learner_id] FOREIGN KEY([learner_id])
REFERENCES [dbo].[user] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [FK_attendance_user_learner_id]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [FK_course_program_program_id] FOREIGN KEY([program_id])
REFERENCES [dbo].[program] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [FK_course_program_program_id]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [FK_course_user_instructor_id] FOREIGN KEY([instructor_id])
REFERENCES [dbo].[user] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [FK_course_user_instructor_id]
GO
ALTER TABLE [dbo].[courseregister]  WITH CHECK ADD  CONSTRAINT [FK_courseregister_course_course_id] FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[courseregister] CHECK CONSTRAINT [FK_courseregister_course_course_id]
GO
ALTER TABLE [dbo].[courseregister]  WITH CHECK ADD  CONSTRAINT [FK_courseregister_user_learner_id] FOREIGN KEY([learner_id])
REFERENCES [dbo].[user] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[courseregister] CHECK CONSTRAINT [FK_courseregister_user_learner_id]
GO
ALTER TABLE [dbo].[lesson]  WITH CHECK ADD  CONSTRAINT [FK_lesson_course_course_id] FOREIGN KEY([program_id], [course_number])
REFERENCES [dbo].[course] ([program_id], [course_number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[lesson] CHECK CONSTRAINT [FK_lesson_course_course_id]
GO
ALTER TABLE [dbo].[lesson]  WITH CHECK ADD  CONSTRAINT [FK_lesson_timeslot_timeslot] FOREIGN KEY([timeslot])
REFERENCES [dbo].[timeslot] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[lesson] CHECK CONSTRAINT [FK_lesson_timeslot_timeslot]
GO
ALTER TABLE [dbo].[program_instructor]  WITH CHECK ADD  CONSTRAINT [FK_program_instructor_program_program_id] FOREIGN KEY([program_id])
REFERENCES [dbo].[program] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[program_instructor] CHECK CONSTRAINT [FK_program_instructor_program_program_id]
GO
ALTER TABLE [dbo].[program_instructor]  WITH CHECK ADD  CONSTRAINT [FK_program_instructor_user_instructor_id] FOREIGN KEY([instructor_id])
REFERENCES [dbo].[user] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[program_instructor] CHECK CONSTRAINT [FK_program_instructor_user_instructor_id]
GO
ALTER TABLE [dbo].[review]  WITH CHECK ADD  CONSTRAINT [FK_review_program_program_id] FOREIGN KEY([program_id])
REFERENCES [dbo].[program] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[review] CHECK CONSTRAINT [FK_review_program_program_id]
GO
ALTER TABLE [dbo].[review]  WITH CHECK ADD  CONSTRAINT [FK_review_user_learner_id] FOREIGN KEY([learner_id])
REFERENCES [dbo].[user] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[review] CHECK CONSTRAINT [FK_review_user_learner_id]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_role_role_id] FOREIGN KEY([role_id])
REFERENCES [dbo].[role] ([id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_role_role_id]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_user_email] CHECK  (([email] like '%[A-Za-z0-9]@[A-Za-z0-9]%.[A-Za-z0-9]%'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_user_email]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [CK_user_phone] CHECK  (([phone] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' OR [phone] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [CK_user_phone]
GO
USE [master]
GO
ALTER DATABASE [YogaCenter] SET  READ_WRITE 
GO
