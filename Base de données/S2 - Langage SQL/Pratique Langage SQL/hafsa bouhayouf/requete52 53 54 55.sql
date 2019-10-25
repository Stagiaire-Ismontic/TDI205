create table Employé(num int,nom varchar(100),ville varchar(100),salaire int)
insert into Employé values(1,'jk','rabat',5000)
insert into Employé values(2,'tk','fes',6000)
insert into Employé values(3,'v','tanger',3000)
insert into Employé values(4,'jm','casablanca',0)
Select * From Employé where salaire =(select MAX(salaire) From
Employé);

Select * from Employé where salaire IN (Select MAX(salaire) as
SalaireMax from Employé GROUP BY ville);
Select * From Employé where salaire> ANY(Select MAX (salaire) from
Employé GROUP BY ville);
Select * From Employé where salaire< All(select MAX (salaire) from
Employé GROUP BY ville) ;