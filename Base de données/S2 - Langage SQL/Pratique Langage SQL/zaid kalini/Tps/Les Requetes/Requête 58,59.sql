Create VIEW ListeStagiaires as Select nom as 'Nom stagiare', id from Stagiaires ;
Create index index_nom on [dbo].[Stagiaires](nom);