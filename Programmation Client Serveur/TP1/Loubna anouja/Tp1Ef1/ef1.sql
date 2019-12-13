USE master
IF EXISTS(select * from sys.databases where name='loubna')
DROP DATABASE loubna	
GO
CREATE DATABASE loubna
GO
USE loubna

-- Création des tables
create table commande(
 Id int primary key identity(1,1),
 Code varchar(50),
 Nom varchar(50)
);

create table livraison(
 Id int primary key identity(1,1),
 Datelivraison datetime,
 IdCommande int foreign key references commande(Id)
 );
 
-- Jeux de text
 SET IDENTITY_INSERT commande  OFF
SET IDENTITY_INSERT livraison OFF

SET IDENTITY_INSERT commande ON
insert into commande(Id,Code,Nom) values (1,'gtgg','eyo');
insert into commande(Id,Code,Nom) values (2,'TDI2G1','oreo');
insert into commande(Id,Code,Nom) values (3,'TDI2G3','kitkat');
GO
SET IDENTITY_INSERT commande  OFF
SET IDENTITY_INSERT livraison ON
insert into livraison(Id,Datelivraison,IdCommande) values (1,'11/12/1995',1);
insert into livraison(Id,Datelivraison,IdCommande) values (2,'8/6/1994',1);

 SET IDENTITY_INSERT commande  OFF
SET IDENTITY_INSERT livraison OFF
 SET IDENTITY_INSERT commande  ON
SET IDENTITY_INSERT livraison ON

select * from commande;
select * from livraison;