use master;
CREATE database DBSchool;
go
use DBSchool;
go
CREATE TABLE [dbo].[groupe] (
    [Id]  INT           NOT NULL,
    [nom] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[stg] (
    [Id]       INT           NOT NULL,
    [nom]      NVARCHAR (50) NULL,
    [prenom]   NVARCHAR (50) NULL,
    [groupeid] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_stg_ToTable] FOREIGN KEY ([groupeid]) REFERENCES [dbo].[groupe] ([Id])
);