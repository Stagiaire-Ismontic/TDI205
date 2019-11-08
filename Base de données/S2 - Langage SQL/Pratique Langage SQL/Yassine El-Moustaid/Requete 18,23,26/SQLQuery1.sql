create database GestionStagiaire;

create table Groupes(
	id int,
	nom varchar(30),
	Constraint pk_groupe primary key(id)
	);
/*requete 18*/
create table Stagiaires(
	id int,
	nom varchar(30),
	filiere varchar(30),
	note_bac float,
	id_groupe int,
	Constraint n_note Check(note_bac between 0 and 20),
	Check(filiere='tdi'or filiere='tri'),
	Constraint pk_stagiaire primary key(id),
	constraint fk_stagiare_groupe foreign key(id_groupe) references Groupes(id)
);
drop table Stagiaires;
alter table Stagiaires drop constraint pk_stagiaire;
alter table Stagiaires add ville varchar(30);
/*requete 23 */
alter table Stagiaires alter column ville varchar(100);

/*requete 26 */
create table mention(
	id int identity(1,2),
	nom varchar(30),
	nmax float,
	nmin float
	);