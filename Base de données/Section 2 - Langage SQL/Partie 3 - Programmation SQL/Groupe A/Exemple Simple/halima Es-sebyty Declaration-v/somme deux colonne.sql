
create database GestionDesNotes;

create table Etudient(id int primary key not null  ,moy int );

DECLARE @somme int;
set @somme=(select sum(id)+sum(moy) from Etudient);
print @somme;

insert into Etudient values(1,14);
insert into Etudient values(2,16);
select * from Etudient;