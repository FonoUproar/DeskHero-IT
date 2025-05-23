USE [master]
GO
/****** Object:  Database [DeskHeroIt]    Script Date: 4/7/2025 7:47:13 PM ******/
CREATE DATABASE [DeskHeroIt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeskHeroIt_New', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DeskHero_New.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DeskHeroIt_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DeskHero_Log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DeskHeroIt] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeskHeroIt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeskHeroIt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeskHeroIt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeskHeroIt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeskHeroIt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeskHeroIt] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeskHeroIt] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DeskHeroIt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeskHeroIt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeskHeroIt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeskHeroIt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeskHeroIt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeskHeroIt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeskHeroIt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeskHeroIt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeskHeroIt] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DeskHeroIt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeskHeroIt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeskHeroIt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeskHeroIt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeskHeroIt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeskHeroIt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeskHeroIt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeskHeroIt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeskHeroIt] SET  MULTI_USER 
GO
ALTER DATABASE [DeskHeroIt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeskHeroIt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeskHeroIt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeskHeroIt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DeskHeroIt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DeskHeroIt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DeskHeroIt] SET QUERY_STORE = ON
GO
ALTER DATABASE [DeskHeroIt] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DeskHeroIt]
GO
/****** Object:  Table [dbo].[priorities]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[priorities](
	[priority_id] [int] IDENTITY(1,1) NOT NULL,
	[priority_level] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[priority_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proficiencies]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proficiencies](
	[proficiency_id] [int] NOT NULL,
	[profiency_level] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_proficiencies] PRIMARY KEY CLUSTERED 
(
	[proficiency_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[team_members]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[team_members](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[proficiency_id] [int] NOT NULL,
 CONSTRAINT [PK_team_members] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[ticket_id] [int] IDENTITY(1,1) NOT NULL,
	[priority_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[description] [varchar](max) NULL,
	[creation_time] [datetime] NOT NULL,
	[completion_flag] [bit] NOT NULL,
	[team_member_assigned_id] [int] NOT NULL,
	[completion_time] [datetime] NULL,
	[proficiency_id] [nchar](10) NOT NULL,
	[estimated_time_to_complete] [int] NULL,
 CONSTRAINT [PK__tickets__D596F96B2A87BBFF] PRIMARY KEY CLUSTERED 
(
	[ticket_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tickets] ADD  CONSTRAINT [DF__tickets__created__46E78A0C]  DEFAULT (getdate()) FOR [creation_time]
GO
ALTER TABLE [dbo].[tickets] ADD  CONSTRAINT [DF__tickets__trash_f__47DBAE45]  DEFAULT ((0)) FOR [completion_flag]
GO
ALTER TABLE [dbo].[team_members]  WITH CHECK ADD  CONSTRAINT [FK_team_members_team_members] FOREIGN KEY([proficiency_id])
REFERENCES [dbo].[proficiencies] ([proficiency_id])
GO
ALTER TABLE [dbo].[team_members] CHECK CONSTRAINT [FK_team_members_team_members]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [priority_id] FOREIGN KEY([team_member_assigned_id])
REFERENCES [dbo].[team_members] ([Id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [priority_id]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMember_Insert]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMember_Insert]
    @Name NVARCHAR(100),
    @ProficiencyId INT,
    @id INT OUTPUT
AS
BEGIN
    INSERT INTO team_members(Name, proficiency_id)
    VALUES (@Name, @ProficiencyId);

    SET @id = SCOPE_IDENTITY(); 
END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_DeleteSelected]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_DeleteSelected]
    @Id INT
AS
BEGIN
    -- Delete the team member with the specified Id from the TeamMembers table
    DELETE FROM team_members
    WHERE Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetAll]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTeamMembers_GetAll]
AS
BEGIN
    -- Select all team members from the TeamMembers table
    SELECT *  -- Adjust columns as per your table structure
    FROM team_members;
END
GO
/****** Object:  StoredProcedure [dbo].[spTickets_DeleteSelected]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTickets_DeleteSelected]
    @Id INT
AS
BEGIN
    -- Delete the ticket from the Tickets table where the Id matches
    DELETE FROM tickets
    WHERE ticket_id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[spTickets_GetAll]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTickets_GetAll]
AS
BEGIN
    -- Select all tickets from the Tickets table
    SELECT *
	FROM tickets;
END
GO
/****** Object:  StoredProcedure [dbo].[spTickets_Insert]    Script Date: 4/7/2025 7:47:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spTickets_Insert]
    @Name NVARCHAR(100),
    @Priority NVARCHAR(50),
    @ProficiencyId INT,
    @TeamMemberAssigned NVARCHAR(100),
    @EstimatedTimeToComplete INT,
    @Description NVARCHAR(500),
    @id INT OUTPUT
AS
BEGIN
    -- Insert a new ticket into the Tickets table
    INSERT INTO tickets (Name, priority_id, proficiency_id, team_member_assigned_id, estimated_time_to_complete, Description)
    VALUES (@Name, @Priority, @ProficiencyId, @TeamMemberAssigned, @EstimatedTimeToComplete, @Description);

    -- Set the output parameter to the newly generated id
    SET @id = SCOPE_IDENTITY(); -- Get the ID of the last inserted record
END
GO
USE [master]
GO
ALTER DATABASE [DeskHeroIt] SET  READ_WRITE 
GO
