create table employee(
	id int identity,
	salaire money,
	ville varchar(30)
);

drop table employee;



insert into employee(salaire,ville) values (10,'las vegas');


select * from employee  where salaire= (select max(salaire) from employee);


