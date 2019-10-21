  create login Amine with password='123456', default_database= GestionProjet

create database GestionProjet
use GestionProjet

create table Projets
(
 Id int ,
 titre varchar(50),
 Nbrjourrealisation int,
)
create table Taches
(
  id int,
  titre varchar(50),
  projet_id int,
  nbrjourrealis int,
)
create table stagiares 
(
  id int,
  nom varchar(50),
  prenom varchar(50),
  cin int,
  e_email varchar(50),
  datenaissance date,
  telefix int,
  teleportable int,
)
create table TachesSragiares
(
  stagiare_id int,
  tache_id int,
  datedebut date,
  datefin date,
)

  drop login Amine
     

  /*Table projet*/

  grant update on Projet to Amine with grant option
  deny update Projet to Amine cascade
  grant update,select,delete,update,insert on Projet to Amine
  Revoke update,select,delete,update,insert to Amine

  /*Table Taches*/

  grant update on Taches to Amine with grant option
  deny update Taches to Amine cascade
  grant update,select,delete,update,insert on Taches to Amine
  Revoke update,select,delete,update,insert to Amine

    /*Table stagiares*/

  grant update on stagiares to Amine with grant option
  deny update stagiares to Amine cascade
  grant update,select,delete,update,insert on stagiares to Amine
  Revoke update,select,delete,update,insert to Amine

      /*Table stagiares*/

  grant update on TachesSragiares to Amine with grant option
  deny update TachesSragiares to Amine cascade
  grant update,select,delete,update,insert on TachesSragiares to Amine
  Revoke update,select,delete,update,insert to Amine

