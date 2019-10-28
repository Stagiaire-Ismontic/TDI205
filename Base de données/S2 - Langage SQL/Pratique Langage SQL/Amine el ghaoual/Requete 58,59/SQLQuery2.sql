
/*Requête 58 : Exemp le de création d’un view*/
Create VIEW ListeStagiaires as Select Nom, id from Stagiaires ;  
/*Requête 59 : Exemple de création d’un index*/
Create index index_nom on Stagiaires(nom);