Create Table TachesStagiaires(
	stagiaire_id int foreign key references stagiaires(id),
	tache_id int foreign key references Taches(id),
	date_debut date,
	date_fin date,
);