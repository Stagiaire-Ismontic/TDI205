create database GES
use GES
create table clientt
(
 id int primary key identity(1,2),
 nom varchar(50),
 prenome varchar(50),
 datajoute datetime,
 budget float
)


insert into clientt(nom,prenome,datajoute,budget) values('saad ','prenom ','22/05/2000 ',123.5);


select cast (id  as varchar) +cast(datajoute as varchar)+ cast(budget as varchar)  + nom + prenome from client;




