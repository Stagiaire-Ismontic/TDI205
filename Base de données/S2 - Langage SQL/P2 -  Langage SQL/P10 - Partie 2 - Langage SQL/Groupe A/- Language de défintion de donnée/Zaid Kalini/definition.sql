create database gestion;
use gestion;
create table tache(idTach int primary key, descTach varchar(50))
alter table tache add  NomdeTach varchar(50)
alter table tache drop column NomdeTach
drop table tache
use master
drop database gestion;
