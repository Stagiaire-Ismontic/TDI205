-- Création de la base de données
USE master
IF EXISTS(select * from sys.databases where name='GestionStagiaires')
DROP DATABASE GestionStagiaires
GO
CREATE DATABASE GestionStagiaires
GO
USE GestionStagiaires

-- Création des tables
create table Groupes(
 Id int primary key identity(1,1),
 Code varchar(50),
 Nom varchar(50)
);

create table Stagiaires(
 Id int primary key identity(1,1),
 Nom varchar(50),
 Prenom varchar(50),
 DateNaissance datetime,
 IdGroupe int foreign key references Groupes(Id)
 );

-- Jeux de test
SET IDENTITY_INSERT Groupes  OFF
SET IDENTITY_INSERT Stagiaires OFF

SET IDENTITY_INSERT Groupes ON
insert into Groupes(Id,Code,Nom) values (1,'TDI2G1','TDI Groupe 1');
insert into Groupes(Id,Code,Nom) values (2,'TDI2G1','TDI Groupe 2');
insert into Groupes(Id,Code,Nom) values (3,'TDI2G3','TDI Groupe 3');
GO
SET IDENTITY_INSERT Groupes  OFF
SET IDENTITY_INSERT Stagiaires ON
insert into Stagiaires(Id,Nom,Prenom,DateNaissance,IdGroupe) values (1,'Madani','Ali','11/12/1995',1);
insert into Stagiaires(Id,Nom,Prenom,DateNaissance,IdGroupe) values (2,'Chami','Moad','8/6/1994',1);

 SET IDENTITY_INSERT Groupes  OFF
SET IDENTITY_INSERT Stagiaires OFF
 SET IDENTITY_INSERT Groupes  ON
SET IDENTITY_INSERT Stagiaires ON

select * from Groupes;
select * from Stagiaires;