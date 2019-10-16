create table emplyeur
(
   id int,
   salaire float,
   prime float,
   nom varchar(15)
);

insert into emplyeur values (5,3000,500,'Mohcine');
insert into emplyeur values (5,2000,500,'Nordin');

declare @SommeSalaire float;

set @SommeSalaire=(select sum(salaire)+sum(prime) from emplyeur);

print @SommeSalaire;
