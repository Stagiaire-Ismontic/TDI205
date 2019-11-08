create database ANAS_JALAL_ZERHOUNI;
use ANAS_JALAL_ZERHOUNI;

Create table Groupes( 
	id int,
	nom varchar(50),
	Constraint pk_groupe Primary key(id) 
);

Create table Stagiaires(
	id int,
	nom varchar(30),
	note_bac float,
	fillier varchar(30),
	id_groupe int,
	constraint n_note check(note_bac between 0 and 20),
	check(fillier='tdi' or fillier='tri'),
	constraint pk_stagiaire Primary key(id),
	constraint fk_stagiare_groupe Foreign key(id_groupe) references Groupes(id)
);


