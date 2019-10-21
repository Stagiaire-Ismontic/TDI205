create database gestion_banque;
create table projets(id_projet int, titre varchar);
create table taches(id_tache int);
create table stagiaires(id_stagiaire int);
create table tachestagiaires(id_tache int,id_stagiaires int);

alter table stagiaires add age int;
alter table stagiaires drop column age;
drop database gestion_banque;