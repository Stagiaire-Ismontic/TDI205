create database gestionprojet ;

create table projets(id int primary key,nom varchar(10),num_jours int);

 insert into projets values (1,'recherche',3);
  insert into projets values (2,'presentation',2);

  declare @som float;

set @som = (select sum(num_jours) from projets)

PRINT @som;
