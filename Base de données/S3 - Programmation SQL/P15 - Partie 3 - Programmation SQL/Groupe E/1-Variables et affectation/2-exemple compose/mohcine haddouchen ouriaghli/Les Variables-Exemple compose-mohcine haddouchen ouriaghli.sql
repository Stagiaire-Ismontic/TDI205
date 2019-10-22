create database classe;
create table stagaire(id int,nom nvarchar(30));
select cast(id as nvarchar)+nom from stagaire;