USE [Etablissment]
GO
/****** Object:  Table [dbo].[Formateur]    Script Date: 12/22/2019 10:27:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formateur](
	[id] [int] NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prenom] [varchar](50) NULL,
	[idMod] [int] NULL,
 CONSTRAINT [PK_Formateur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Module]    Script Date: 12/22/2019 10:27:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module](
	[idMod] [int] NOT NULL,
	[Nom] [varchar](50) NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[idMod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Formateur]  WITH CHECK ADD  CONSTRAINT [FK_Formateur_Module] FOREIGN KEY([idMod])
REFERENCES [dbo].[Module] ([idMod])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Formateur] CHECK CONSTRAINT [FK_Formateur_Module]
GO
