create database GestionProjets 
create table Stagiaires
(
id int,
nom varchar(50),
prenom varchar(50),
cin varchar(10),
ville varchar(20),
date_naissance date,
e_mail varchar(50),
tel_fix int,
tel_portable int
);
create table Projets
(
  id int,
  titre varchar(50),
  nbrj_realisation int
)
create table Taches
(
id int,
titre varchar(50),
projet_id int,
nbj_relisation int
)
create table TachesStagiaires
(
 stagiaire_id int,
 tache_id int,
 date_debut date,
 date_fin date,
)
