create table Employe(num int, nom nvarchar(30),ville nvarchar(30),salaire int);
insert into Employe values(1,'mohamed','tanger',4000);
insert into Employe values(2,'Bilal','Casa',4500);
insert into Employe values(3,'achraf','Rabat',3800);
insert into Employe values(4,'Said','Tetouan',8000);
insert into Employe values(5,'Ismail','Chaoun',10000);
select * from Employe;
select * from Employe where salaire=(select max(salaire) from Employe);
