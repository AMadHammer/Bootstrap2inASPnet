
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/19/2013 00:48:59
-- Generated from EDMX file: C:\Users\AAhmed\documents\visual studio 2010\Projects\Resume Builder\ResumeBuilder.Core\ResumeModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ResumeDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserResume]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resumes] DROP CONSTRAINT [FK_UserResume];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Resumes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Resumes];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Resumes'
CREATE TABLE [dbo].[Resumes] (
    [ResumeIDKey] int IDENTITY(1,1) NOT NULL,
    [LastUpdated] datetime  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NOT NULL,
    [MissionStatement] nvarchar(max)  NOT NULL,
    [School] nvarchar(max)  NOT NULL,
    [Certifications] nvarchar(max)  NOT NULL,
    [JobExperience] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [UserUserIDKey] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserIDKey] int IDENTITY(1,1) NOT NULL,
    [TestValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [SchoolId] int IDENTITY(1,1) NOT NULL,
    [SchoolName] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Major] nvarchar(max)  NOT NULL,
    [ResumeIDKey] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WorkExperiences'
CREATE TABLE [dbo].[WorkExperiences] (
    [WorkExperienceId] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [ResumeIDKey] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WorkExpPositions'
CREATE TABLE [dbo].[WorkExpPositions] (
    [WorkExpPosId] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Responsibility] nvarchar(max)  NOT NULL,
    [WorkTitle] nvarchar(max)  NOT NULL,
    [WorkExperienceId] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ResumeIDKey] in table 'Resumes'
ALTER TABLE [dbo].[Resumes]
ADD CONSTRAINT [PK_Resumes]
    PRIMARY KEY CLUSTERED ([ResumeIDKey] ASC);
GO

-- Creating primary key on [UserIDKey] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserIDKey] ASC);
GO

-- Creating primary key on [SchoolId] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([SchoolId] ASC);
GO

-- Creating primary key on [WorkExperienceId] in table 'WorkExperiences'
ALTER TABLE [dbo].[WorkExperiences]
ADD CONSTRAINT [PK_WorkExperiences]
    PRIMARY KEY CLUSTERED ([WorkExperienceId] ASC);
GO

-- Creating primary key on [WorkExpPosId] in table 'WorkExpPositions'
ALTER TABLE [dbo].[WorkExpPositions]
ADD CONSTRAINT [PK_WorkExpPositions]
    PRIMARY KEY CLUSTERED ([WorkExpPosId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserUserIDKey] in table 'Resumes'
ALTER TABLE [dbo].[Resumes]
ADD CONSTRAINT [FK_UserResume]
    FOREIGN KEY ([UserUserIDKey])
    REFERENCES [dbo].[Users]
        ([UserIDKey])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserResume'
CREATE INDEX [IX_FK_UserResume]
ON [dbo].[Resumes]
    ([UserUserIDKey]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------