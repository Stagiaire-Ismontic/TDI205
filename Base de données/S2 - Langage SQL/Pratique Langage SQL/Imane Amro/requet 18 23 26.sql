CREATE DATABASE GestionStagiaires
/*requet 18*/
create table Groupes(id int primary key)
Create table Stagiaires(
 id int,
  nom varchar(50), 
  note_bac float, 
   filiere varchar(50),
   prenom varchar(50),
   id_groupe int,
   ville varchar(50), 
   Constraint n_note Check(note_bac between 0 and 20),
   Check(filiere='tdi'or filiere='tri'),
 Constraint pk_stagiairee  Primary key(id),
  Constraint fk_stagiaire_groupe Foreign key (id_groupe) References Groupes(id) );
  
  /*requet 23*/
  
Alter table Stagiaires Alter column ville varchar(100) not null;
  /*requet 26*/
  Create table Mention ( id int Identity( 1 ,2 ), nom varchar(50),
 nmax float, nmin float )

  