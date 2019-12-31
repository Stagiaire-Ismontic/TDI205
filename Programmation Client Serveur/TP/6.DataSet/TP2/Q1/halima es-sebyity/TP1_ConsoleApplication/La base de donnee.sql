create database Biblio_des_Livre
create table Livre(id int primary key ,titre varchar(50),categorie varchar(50),nom_auteur varchar(50))

select * from Livre

truncate table Livre

delete from Livre where id=1