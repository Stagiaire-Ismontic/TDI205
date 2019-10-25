create database GestionStagiaires;
create table Groupes(id int primary key, Nom varchar(100));
Create table Stagiaires(id int, nom varchar(50), note_bac float, filiere varchar(50), id_groupe int,
 Constraint n_note Check(note_bac between 0 and 20), Check(filiere='tdi'or filiere='tri'), 
 Constraint pk_stagiaire Primary key(id), Constraint fk_stagiaire_groupe Foreign key(id_groupe) References Groupes(id))
insert into Stagiaires values(1,'ali',13,'tri',101)
insert into Stagiaires values(2,'omar',15,'tdi',101)
insert into Stagiaires values(1,'ilias',17,'tdi',102)
insert into Stagiaires values(1,'kawkaw',0,'tri',101)