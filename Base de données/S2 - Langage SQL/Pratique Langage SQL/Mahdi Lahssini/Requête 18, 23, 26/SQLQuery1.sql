create database GestionStagiaires;

create table Groupe(Id int primary key not null,Nom varchar(50));
create table Stagiaire(Id varchar(50),Nom varchar(50),IdGroupe varchar(50));