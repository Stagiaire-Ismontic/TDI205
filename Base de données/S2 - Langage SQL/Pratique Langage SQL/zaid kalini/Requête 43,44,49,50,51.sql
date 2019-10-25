Alter table Stagiaires add DateNaissance Datetime;
Select [nom],[note_bac] from [dbo].[Stagiaires] ORDER BY [note_bac] ASC;
Select [nom],[note_bac] from [dbo].[Stagiaires] ORDER BY [note_bac] DESC;
Select MAX([note_bac]) as NoteMaximum from Stagiaires;
Select ville , MAX([note_bac]) as NoteMax From Stagiaires GROUP BY ville;
Select ville , MAX([note_bac]) as NoteMax From Stagiaires GROUP BY ville HAVING MAX([note_bac]) > 15 ;
