create database Gestion_Projets;
create table  Stagiaires ( id int primary key identity(1,1),
nom nvarchar(50),
prenom nvarchar(20),
cin nvarchar(50),
ville nvarchar(50),
date_naissance date,
e_mail nvarchar(50),
tel_fixe int,
tel_portable int);


create table Projets (id int primary key,
titre nvarchar(50),
nombre_jours_realisation int);


create table Taches (id int primary key,
titre nvarchar(50),
projet_id int constraint pt_id  foreign key(id) references Projets(id),
nombre_jours_realisation int);


create table TachesStagiaires (stagiaire_id int,
tache_id int constraint st_id foreign key(tache_id)references Taches(id),
date_debut date,
date_fin date);





--truncate table TachesStagiaires; empty
