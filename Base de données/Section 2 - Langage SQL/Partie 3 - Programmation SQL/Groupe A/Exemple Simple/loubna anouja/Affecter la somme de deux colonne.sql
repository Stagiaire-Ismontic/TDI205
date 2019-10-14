create table LOULOU(
	id int,
	salaire float,
	nom varchar(50)
);
insert into LOULOU values (1,9000,'LOUBNA');
insert into LOULOU values (2,8000,'IMANE');

declare @somme float;

set @somme = (select sum(id)+sum(salaire) from LOULOU)

PRINT @somme;