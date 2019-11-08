create database GestionProjets;
create table Stagiaires(
id int,
nom varchar(30),
prenom varchar(30),
cin varchar(30),
date_naissance varchar(30),
e_mail varchar(30),
tel_fixe int,
tel_portable int);


create table Projets(
id int,
titre varchar(30),
nombre_jours_realisation int
);
create table Taches(
id int ,
titre varchar(30),
projet_id int,
nombre_jours_realisation int
);
create table TachesStagiaires(
stagiaire_id int,
tache_id int,
date_debut varchar(30),
date_fin varchar(30)
);
