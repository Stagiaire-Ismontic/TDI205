create database GestionProjets;

create table Stagiaires (id int, nom varchar(50), prenom varchar(50), cin varchar(50), ville varchar(50), date_naissance date, e_mail varchar(50), tel_fixe varchar(50), tel_portable varchar(50)) ;
create table Projets (id int, titre varchar(50), nombre_jours_realisation int) ;
create table Taches (id int, titre varchar(50), projet_id int, nombre_jours_realisation int) ;
create table TachesStagiaires (stagiaire_id int, tache_id int, date_debut date, date_fin time);







insert into Stagiaires values(1,'Madani','Ali','K380001','tanger','madani.ali@gmail.com','05/06/1995','0539 00 00 01','06 00 00 00 01');
insert into Stagiaires values(2,'Madani','moad','K380002','tanger','madani.moad@gmail.com','05/06/1997','0539 00 00 02','06 00 00 00 02');