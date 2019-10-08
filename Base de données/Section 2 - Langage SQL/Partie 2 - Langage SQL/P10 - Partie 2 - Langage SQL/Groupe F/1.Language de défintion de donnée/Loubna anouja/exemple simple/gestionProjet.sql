create database GestionProjet;
create table Projets(id int,titre varchar(30));
alter table Projets add idprjt varchar(30);
alter table Projets drop  column idprjt;
drop table projets;
drop database GestionProjets;