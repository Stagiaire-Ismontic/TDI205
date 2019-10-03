create database Yassine;

create table Elm(
cin int, tele varchar(15));

alter table Elm add email varchar(30);

select *from Elm;

alter table Elm drop column email;

drop table Elm;

drop database Yassine;
