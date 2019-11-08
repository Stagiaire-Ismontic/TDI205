create database GestionStagiaires
create table stagiairees(id int,nom varchar(50),prenom varchar(50),cin varchar(50),ville varchar(50),date_naissance varchar(50),email varchar( 50),tel_fix varchar(50),tel_portqble varchar(50))
create table Projets (id int, titre varchar(50), nombre_jours_realisation int) create table Taches (id int, titre varchar(50), projet_id int, nombre_jours_realisation int)
 create table TachesStagiairees (stagiaire_id int, tache_id int, date_debut dateTIME,
date_fin dateTIME)
