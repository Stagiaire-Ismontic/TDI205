create database note

create Table moyen_etudiant(id int primary key not null ,note int);

DECLARE @moyen int;
set @moyen=(select sum(id)+sum(note) From moyen_etudiant);
print @moyen;

insert into moyen_etudiant values(1,14);
insert into moyen_etudiant values(2,16);
select*from moyen_etudiant;