create table stagiaires(note float,bourse float,nom varchar(30));
insert into stagiaires values(12,950,'omar');
insert into stagiaires values(16,950,'YASSINE');
insert into stagiaires values(10,950,'madani');

declare @somme float;
set @somme=(select sum(note)+sum(bourse) from stagiaires);
print @somme;
