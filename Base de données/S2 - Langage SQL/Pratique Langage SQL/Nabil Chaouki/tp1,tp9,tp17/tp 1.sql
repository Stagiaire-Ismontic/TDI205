create database GestionProjets;
create table Stagiaire (id int, nom varchar(20), prenom varchar(20), cin varchar(20), ville varchar(10), date_naissance datetime,
 e_mail varchar (20), tel_fixe varchar(10), tel_portable varchar(10)) 
create table Projets (id int, titre varchar(20), nombre_jours_realisation int) 
create table Taches (id int, titre varchar(20), projet_id int, nombre_jours_realisation int) 
create table TachesStagiaires (stagiaire_id int, tache_id int, date_debut datetime, date_fin datetime)