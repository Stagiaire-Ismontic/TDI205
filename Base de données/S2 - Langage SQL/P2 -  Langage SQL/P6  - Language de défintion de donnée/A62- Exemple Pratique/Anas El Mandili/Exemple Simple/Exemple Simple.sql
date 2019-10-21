create database GestionProjets;

create table Projets(id int,Titre varchar(20));

alter table Projets add Nomre_jour_creation int;

alter table Projets drop column Titre;

drop table Projets;

drop database GestionProjets;