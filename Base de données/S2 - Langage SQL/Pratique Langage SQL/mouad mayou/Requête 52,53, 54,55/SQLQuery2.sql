create database Entreprise;
create table Employe(num int,nom varchar(30),ville varchar(30), salaire float);
insert into Employe values(1,'Yemlahi','Tanger',3000);
insert into Employe values(2,'Kassimi','Casa',5000);
insert into Employe values(3,'Bourebah','Fes',4000);
insert into Employe values(4,'Rachidi','Tanger',6000);
insert into Employe values(5,'Jabiri','Casa',2000);
/*Requête 52*/
Select * From Employe where salaire =(select MAX(salaire) From Employe) ; 
/*Requête 53*/
Select * from Employe where salaire IN (Select MAX(salaire) as SalaireMax from Employe GROUP BY ville) ; 
/*Requête 54*/
Select * From Employe where salaire> ANY(Select MAX (salaire) from Employe GROUP BY ville) ; 

/*Requête 55*/

Select * From Employe where salaire< All(select MAX (salaire) from Employe GROUP BY ville) ; 