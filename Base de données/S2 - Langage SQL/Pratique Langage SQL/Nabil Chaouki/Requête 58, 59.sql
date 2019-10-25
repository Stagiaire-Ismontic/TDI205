Create VIEW ListeStagiaires as Select nom, id from Stagiaires ;
Create index index_nom on [dbo].[Stagiaires](nom);