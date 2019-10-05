Create Table stagiaires(
	id int not null primary key,
	nom varchar(30),
	prenom varchar(30),
	CIN varchar(20),
	email varchar(30),
	date_naissance date,
	tel_fix varchar(30),
	tel_portable varchar(30)
);