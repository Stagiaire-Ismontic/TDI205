CREATE TABLE Projets(
	id int,
	titre varchar(30),
	date_debut date,
	date_modification date,
	constraint chk_titre check (titre='Projet1' OR titre='Projet2'),
	constraint chk_date check (date_debut<date_modification)
);
