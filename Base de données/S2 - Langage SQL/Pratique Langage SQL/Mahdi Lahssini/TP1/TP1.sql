create database TP1;
create table Stagiaires (id int, nom varchar(50), prenom varchar(50), cin int, ville varchar(50),
date_naissance date,e_mail varchar(50), tel_fixe varchar(50), tel_portable varchar(50));
create table Projets (id int, titre varchar(50), nombre_jours_realisation date);
create table Taches (id int, titre varchar(50), projet_id int, nombre_jours_realisation date);
create table TachesStagiaires (stagiaire_id int, tache_id int, date_debut date,date_fin date);