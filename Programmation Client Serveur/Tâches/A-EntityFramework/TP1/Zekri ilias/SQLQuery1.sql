Create database GestionFacture

use GestionFacture

create table facture(IdFac int primary key,Nom varchar(50) );

create table banq(Id int primary key,FacId int,Nom varchar(50),Constraint FKCCL Foreign key (FacId) References facture(IdFac));