create database gestionprojets;

create table stagiaire(id int primary key,nom varchar(20),prenom varchar(20),cin varchar(20),ville varchar(20),date_naissance date,e_mail varchar(20),tel_fixe int,tel_portable int);

create table projets(id int primary key,titre varchar(30),nombre_jours_realisation int);

create table taches(id int primary key,titre varchar(30),projet_id int ,nombre_jours_realisation int ,foreign key (projet_id) references projets(id));

create table tachesStagiaiers(satgiaier_id int,tache_id int,primary key(satgiaier_id,tache_id),date_debut date,date_fin date ,foreign key(satgiaier_id) references stagiaire(id),foreign key(tache_id) references taches(id));

