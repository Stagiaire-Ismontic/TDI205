Create VIEW ListeStagiaires as Select Nom, id from Stagiaires ; 
Create index index_nom on Stagiaires(nom);