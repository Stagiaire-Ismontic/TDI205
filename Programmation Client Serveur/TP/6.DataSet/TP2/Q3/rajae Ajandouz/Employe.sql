create database Employe 
use Employe
drop table employe
create table employe(id int primary key ,Nom varchar(20),Prenom varchar(20),Adress varchar(50) )
create table Salaire(idS int primary key ,salairebase int,idE int foreign key references employe(id))
insert into employe values(1,'rajae','aaa','Tanger')
insert into employe values(2,'sos','bbbb','chawen')
insert into employe values(3,'tat','ccccc','tetouan')
insert into Salaire values(1,2000,1)
insert into Salaire values(2,1000,2)
insert into Salaire values(3,5000,3)

select * from employe
select * from Salaire
