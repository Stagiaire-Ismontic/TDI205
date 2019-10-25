create database Gestion_Stagiaires;
create table Groupes(id int,nom varchar(50),constraint pk_groupe primary key(id));

create table Stagiaires(id int,nom varchar(50),note_bac float,filiere varchar(50),id_groupe int,
   constraint n_note check(note_bac between 0 and 20),
   check(filiere='tdi' or filiere='tri' ),
   constraint pk_stagiaire primary key(id),
   constraint fk_stagiaire_groupe foreign key(id_groupe)References 
   groupes(id)
   );
     
	  create table Mention(
	  id int identity(1,2),
	  nom varchar(50),
	  nmax float,
	  nmin float
	  );
 Alter table Stagiaires Add ville varchar(50);
	 

 alter table Stagiaires alter column ville varchar(100) not null;