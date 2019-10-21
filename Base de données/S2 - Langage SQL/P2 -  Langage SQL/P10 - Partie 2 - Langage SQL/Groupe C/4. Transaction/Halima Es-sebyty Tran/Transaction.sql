create database gestionProj;

create table Projet(id int primary key not null  , titre varchar(20),nombre_jour_realisation int);

create table Tache(id int primary key not null , titre varchar(20) ,id_projet int,nombre_jour_realisation int);

create table TacheStagiaire(id int primary key not null ,id_tache int,date_debut date ,date_fin date);


insert into Projet values(1,'Projet 1',10),
                         (2,'Projet 2',20),
						 (3,'Projet 3',30),
                         (4,'Projet 4',40);

select *from Projet;

begin transaction; 
  
   delete from Projet where id=1;
 
 commit; 

 insert into Tache values(10,'Projet 1',1,01),
                         (20,'Projet 2',2,01);
						

select *from Tache;

begin transaction; 
  
   delete from Tache where id_projet=1;
 
 rollback; 


insert into TacheStagiaire values(100,10,'01/01/02','01/01/04'),
                                 (200,10,'01/01/08','01/01/10');
						

select *from TacheStagiaire;

begin transaction; 
  
   delete from TacheStagiaire where id_tache=10;
   update TacheStagiaire set date_fin='01/01/06' where id=100;
 save transaction tr; 					