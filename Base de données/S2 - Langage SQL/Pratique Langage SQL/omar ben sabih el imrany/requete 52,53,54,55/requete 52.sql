create table Employé(num int,nom varchar(100),ville varchar(100),salaire int)
insert into Employé values(1,'moahmed','tanger',2000)
insert into Employé values(2,'ayoub','rabat',2300)
insert into Employé values(3,'abslam','agadir',2500)
insert into Employé values(4,'kawkaw','laarach',0)
Select * From Employé where salaire =(select MAX(salaire) From
Employé);