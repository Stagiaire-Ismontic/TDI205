create table employer(num int,nom varchar(30),ville varchar(30),salaire float);
Select * from employer where salaire IN (Select MAX(salaire) as SalaireMax from employer GROUP BY ville) ; 
insert into employer values(1,'emp1','ville1',5000),(2,'emp2','ville2',8000),(3,'emp3','ville1',9000);
