
create database CasttData

create table Stagaire(
	Id int identity,
	Nome varchar(30),
	Moy int
);
insert into Stagaire(Nome,Moy) values ('mostapha',19);

select CAST(Id as varchar(30))+Nome from Stagaire;
select * from Stagaire;


