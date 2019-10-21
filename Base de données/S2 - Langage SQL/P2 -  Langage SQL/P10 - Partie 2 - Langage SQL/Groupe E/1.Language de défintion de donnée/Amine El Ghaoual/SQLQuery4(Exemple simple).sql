create database GestionProjet


create table Projet
(
  id int,
  titre varchar(50),
  nbrjrrea int,
)

create table Tache
(
  id int,
  titre varchar(50),
  nbrjrreqlis int,
)

alter table Projet add datedebut date ;
alter table Tache drop column titre;
drop table Projet;
drop database GestionProjet;