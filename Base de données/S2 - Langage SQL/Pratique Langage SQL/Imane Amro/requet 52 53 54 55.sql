create table Employé( salaire float,ville varchar(50))

/*requet 52*/
Select * From Employé where salaire =(select MAX(salaire) From Employé) ; 
/*requet 53*/
Select * from Employé where salaire IN (Select MAX(salaire) asSalaireMax from  Employé GROUP BY ville)
/*requet 54*/
Select * From Employé where salaire> ANY(Select MAX (salaire) from Employé GROUP BY ville) 
/*requet 55*/
Select * From Employé where salaire< All(select MAX (salaire) from Employé GROUP BY ville) ;