create table LOULOU(
	id int,
	salaire float,
	nom varchar(50)
);
insert into LOULOU values (1,9000,'LOUBNA');
insert into LOULOU values (2,8000,'IMANE');

declare @somme float;
declare @som float;
set @somme = (select sum(id) from LOULOU)
PRINT @somme;

set @som = (select sum(salaire) from LOULOU)
	
PRINT @som;