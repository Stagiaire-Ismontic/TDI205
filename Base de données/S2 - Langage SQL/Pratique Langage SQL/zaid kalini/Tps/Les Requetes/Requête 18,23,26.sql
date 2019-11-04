Create Database GestionStagiaires;
Create table Groupes(id int,nom varchar(50),Constraint pk_groupe Primary key(id));
Insert into Groupes values(1,'tdi'),(2,'tri')
Create table Stagiaires(id int,nom varchar(50),note_bac float,filiere varchar(50),id_groupe int,Constraint n_note Check(note_bac between 0 and 20),Check(filiere='tdi'or filiere='tri'),Constraint pk_stagiaire Primary key(id),Constraint fk_stagiaire_groupe Foreign key(id_groupe) References Groupes(id));
insert into Stagiaires values(1,'ilias Zekri',12,'tdi',1,'tanger',1996),(2,'mustapha lahyani',12,'tdi',1,'tanger',2000)
Alter table [dbo].[Stagiaires] Add ville varchar(50);
Alter table Stagiaires Alter column ville varchar(100) not null;
Create table Mention (id int Identity( 1 ,2 ),nom varchar(50),nmax float,nmin float);
