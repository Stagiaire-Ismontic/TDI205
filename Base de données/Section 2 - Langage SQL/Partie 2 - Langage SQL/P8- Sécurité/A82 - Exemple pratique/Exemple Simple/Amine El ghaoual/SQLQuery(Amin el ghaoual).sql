create database GProject
use GProject
create table project
(
   id int,
   titre varchar(50),
   nbrjoursreas int,
)
create table Tache
(
   idT int,
   titreT varchar(50),
   nbrjoursreasT int,
)


create login Amine11  with password='12345' ,Default_database=GProject
Drop login Amine10
grant update on Tache to Amine11 with grant option;
deny  update on Tache to Amine11  cascade;
grant update,select,delete,insert on Tache to Amine11;
revoke update,select,delete,insert on Tache to Amine11;

