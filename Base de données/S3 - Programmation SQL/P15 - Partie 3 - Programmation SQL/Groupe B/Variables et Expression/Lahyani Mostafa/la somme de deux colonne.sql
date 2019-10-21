create database GestiondesNotes

create table Etudiant(id int primary key not null,moy int);


insert into Etudiant values(2,16),(3,17);

Declare @somme int;
set @somme=(select sum(id)+ sum(moy) from Etudiant);
print @somme;

select *from Etudiant;

print getdate();