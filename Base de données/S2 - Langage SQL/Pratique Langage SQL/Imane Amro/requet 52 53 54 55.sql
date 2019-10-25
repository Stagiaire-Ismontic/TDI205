create table Employé( salaire float,ville varchar(50))
insert into Employé values(5000,'tanger')
insert into Employé values (3000,'fes'),(6000,'rabat')

/*requet 52*/
 alter table Employé add ville varchar(20);
 Select * From Employé where salaire =(select MAX(salaire) From Employé) ; 
/*requet 53*/
Select * from Employé where salaire IN (Select MAX(salaire) asSalaireMax from  Employé GROUP BY ville)
/*requet 54*/
Select * From Employé where salaire> ANY(Select MAX (salaire) from Employé GROUP BY ville) 
/*requet 55*/
Select * From Employé where salaire< All(select MAX (salaire) from Employé GROUP BY ville) ;