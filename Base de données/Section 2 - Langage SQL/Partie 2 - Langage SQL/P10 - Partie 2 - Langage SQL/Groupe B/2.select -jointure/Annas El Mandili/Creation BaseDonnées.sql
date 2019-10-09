create database GestionProjets;

create table Projets(id int primary key,titre varchar(20),nombre_jour_realisation int );

create table Taches( id int primary key, titre varchar(20), Projet_id int,nombre_jour_realisation int);

create table TachesStagiaire(stagiaire_id int ,tache_id int,primary key(stagiaire_id,tache_id),date_debut date , date_fin date);

