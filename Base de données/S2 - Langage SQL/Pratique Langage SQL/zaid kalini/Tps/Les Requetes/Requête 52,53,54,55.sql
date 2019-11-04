Create Table Employé(Num int,Nom varchar(30),ville varchar(30),salaire float);
insert into Employé values(1,'ilias','tanger',4000),(2,'omar','tanger',3000),(1,'oussama','tanger',5000);
Select * From Employé where salaire =(select MAX(salaire) From Employé) ;
Select * from Employé where salaire IN (Select MAX(salaire) as SalaireMax from Employé GROUP BY ville) ;
Select * From Employé where salaire> ANY(Select MAX (salaire) from Employé GROUP BY ville) ;
Select * From Employé where salaire< All(select MAX (salaire) from Employé GROUP BY ville) ;