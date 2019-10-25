create table Employé(num int, nom varchar(20),ville varchar(25),salaire varchar(20));

insert into Employé values(1,'madani','tanger','2000');
insert into Employé values(2,'samir','tanger','2500');
insert into Employé values(3,'khalil','marakeche','3000');
insert into Employé values(4,'haj','tetoun','6000');
insert into Employé values(5,'smail','safi','5000');

--Requete 52
Select * From Employé where salaire =(select MAX(salaire) From Employé) ;
--Requete 53
Select * from Employé where salaire IN (Select MAX(salaire) as SalaireMax from Employé GROUP BY ville) ; 
--Requte 54
Select * From Employé where salaire > ANY(Select MAX (salaire) from Employé GROUP BY ville) ; 
--requete 55
Select * From Employé where salaire < All(select MAX (salaire) from Employé GROUP BY ville) ; 

