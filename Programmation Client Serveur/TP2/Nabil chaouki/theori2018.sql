create database cinema

use cinema

create table Categorie (codeCat int primary key, libelle varchar(20))

insert into Categorie values (1,'Action')
insert into Categorie values (2,'categorie2')

create table Film (codeF int primary key, Titre varchar(20),langue varchar(20), anneeProduction int,
                   codeCat int foreign key references Categorie(codeCat))

insert into Film values (1,'avatar','Français',2001,1)
insert into Film values (2,'Heart','Anglais',2006,1)
insert into Film values (3,'Greatmar','Français',2009,2)
insert into Film values (4,'mary','Français',2020,1)

create table Juge (codeJuge int primary key, nom varchar(20),prenom varchar(20),nationalite varchar(20))

insert into Juge values (1,'jack','gosling','Française')
insert into Juge values (2,'toni','alberto','Française')
insert into Juge values (3,'yamazaki','chiruki','chinoise')

create table Vote (codeF# int foreign key references Film(codeF),
                   codeJuge# int foreign key references Juge(codeJuge),
				   constraint ch primary key(codeF#,codeJuge#))

insert into Vote values (1,1)
insert into Vote values (1,2)
insert into Vote values (2,2)
insert into Vote values (3,3)

--2) Non, un juge ne peut pas voter pour le méme film, le code film et le code juge qui se trouvent 
--   au niveau de la table Vote sont des clés primaires

--3) create table Film (codeF int primary key, Titre varchar(20),langue varchar(20), anneeProduction int,
--                      codeCat int foreign key references Categorie(codeCat))


--4) alter table Film add constraint ck check (anneeProduction < year(getdate()))


--5) select film.* from film inner join categorie on film.codecat = categorie.codeCat 
--                                             where libelle like 'Action'
--                                                   and anneeProduction>=2016

--6) select nom,prenom from juge where codeJuge in ( select codejuge# from Vote inner join film on Vote.codeF#
--                                                                                           = film.codeF
--																				 where Titre like 'avatar' )

--7) select titre , count(codeF#) as 'nombre de votes' from vote inner join film on vote.codeF# = film.codeF 
--                                                             group by titre
--                                                             order by count(codeF#) desc


--8) select distinct nom from juge inner join vote on juge.codejuge = vote.codeJuge# where vote.codeF# in ( select codeF#
--   from vote inner join juge on vote.codeJuge# = juge.codeJuge where nom like 'toni' and prenom like 'alberto')
