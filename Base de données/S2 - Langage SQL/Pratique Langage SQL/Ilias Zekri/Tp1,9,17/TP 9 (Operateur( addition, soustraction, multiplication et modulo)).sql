Declare @Nombre_Jours int;
Select @Nombre_Jours=Sum(Day(Date_Fin-Date_Debut)) from TachesStagiaires;
Print @Nombre_Jours;

Declare @Nom_et_Prenom varchar(200);
Select @Nom_et_Prenom=Nom+''+Prenom from Stagiaires Where Nom='Ilias';
Print @Nom_et_Prenom;