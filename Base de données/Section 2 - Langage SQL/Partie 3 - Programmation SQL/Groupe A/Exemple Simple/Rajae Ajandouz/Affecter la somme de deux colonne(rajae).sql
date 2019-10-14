create database Ajandouz ;

create table eleve(
  id int primary key,
  nom varchar(10),
  moy float,
  );

 insert into eleve values (1,'anas',15);
  insert into eleve values (2,'amine',12);

  declare @som float;

set @som = (select sum(id)+sum(moy) from eleve)

PRINT @som;
