create table Employe(
id int primary key,
nom varchar(20),
salaire float ,
);
Select * From Employe where salaire =(select MAX(salaire) From Employe) ;