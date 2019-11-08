create table Employé
(
 num int,
 nom varchar(50),
 ville varchar(50),
 salaire float
);
insert into Employé values(1,'karim','tanger',3000)
insert into Employé values(2,'hamid','chaouen',5000)
insert into Employé values(3,'said','fes',6000)


/*Requête 52 : Afficher la liste des employés ayant le salaire maximal*/
Select * From Employé where salaire =(select MAX(salaire) From Employé) ;
/*Requête 53 : Utilisation sous - interrogation avec l’opérateur « IN »*/
Select * from Employé where salaire IN (Select MAX(salaire) as SalaireMax from Employé GROUP BY ville) ;
/*Requête 54 : Utilisation sous - interrogation avec l’opérateur « Any »*/
Select * From Employé where salaire> ANY(Select MAX (salaire) from Employé GROUP BY ville) ;
/*Requête 55 : Utilisation sous - interrogation avec l’opérateur « All »*/
Select * From Employé where salaire< All(select MAX (salaire) from Employé GROUP BY ville) ;