
create database G_TDI

create table Stag(
	id int identity,
	nom varchar(30),
	moyenne int
);

select CAST(id as varchar(30)),nom from Stag;
insert into Stag(nom,moyenne) values ('halima',16);
select * from Stag;

