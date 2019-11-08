

/*Requete 58*/
Create VIEW ListeStagiaires as Select Nom, id from Stagiaires ;  

/*Requete 59*/
Create index index_nom on Stagiaires(Nom); 