create database Gestion_projet;
create table projet(id int, titre varchar(40));
alter table projet add idprjt varchar(50);
alter table projet drop column idprjt ;
drop table projet;
drop database GestionsProject;