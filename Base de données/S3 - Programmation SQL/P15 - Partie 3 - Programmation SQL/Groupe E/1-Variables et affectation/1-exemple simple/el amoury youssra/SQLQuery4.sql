/*declaration des variable*/
Declare @var_1 int;
declare @var_2 varchar(30);
/*affectation des valeur*/
set @var_1=15;
set @var_2='madani';
print @var_1;
print @var_2;
/*affecter la somme de deux coloonne dans une variable*/
create table stagiaire(note float,bourse float,nom varchar(30));
insert into stagiaire values(10,950,'youssra'),
(20,950,'nada'),(18,950,'koki');
declare @somme float;
set @somme=(select SUM(bourse) from stagiaire);
print @somme;