-- Création de la base de données
USE master
IF EXISTS(select * from sys.databases where name='GestionEmployer')
DROP DATABASE GestionEmployer
GO
CREATE DATABASE GestionEmployer
USE GestionEmployer
go
-- Création des tables

create table Entreprise(
 Id int primary key identity(1,1),
 Nom varchar(50),

 );
create table Employer(
 Id int primary key identity(1,1),
Nom varchar(50),
prenom varchar(50),
IdEntreprise int foreign key references Entreprise(id)
);



-- Jeux de text
 SET IDENTITY_INSERT Employer  OFF
SET IDENTITY_INSERT Entreprise OFF

SET IDENTITY_INSERT Entreprise ON
insert into Entreprise(Id,Nom) values (1,'Entreprise 1');
insert into Entreprise(Id,Nom) values (2,'Entreprise 2');
insert into Entreprise(Id,Nom) values (3,'Entreprise 3');
GO
SET IDENTITY_INSERT Entreprise  OFF
SET IDENTITY_INSERT Employer ON
insert into Employer(Id,Nom,Prenom,IdEntreprise) values (1,'Madani','Ali',1);
insert into Employer(Id,Nom,Prenom,IdEntreprise) values (2,'Chami','Moad',1);

 SET IDENTITY_INSERT Entreprise  OFF
SET IDENTITY_INSERT Employer OFF
 SET IDENTITY_INSERT Entreprise ON
SET IDENTITY_INSERT Employer ON

select * from Entreprise;
select * from Employer;

Delete  from Entreprise where Id= '2'