CREATE DATABASE stgrp;

CREATE TABLE [dbo].[Stagiaire] (
    [Id]         INT           NOT NULL,
    [nomComplet] NVARCHAR (50) NULL,
    [Idgrp]      INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Idgrp]) REFERENCES [dbo].[groupe] ([Id])
);

CREATE TABLE [dbo].[groupe] (
    [Id]     INT           NOT NULL,
    [nomgrp] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



