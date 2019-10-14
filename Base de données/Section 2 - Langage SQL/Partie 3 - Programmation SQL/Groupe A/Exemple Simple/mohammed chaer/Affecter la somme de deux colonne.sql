create table student(
	id int,
	salaire float,
	nom varchar(33)
);
insert into student values (7,1000,'jack');
insert into student values (1,1700,'jass');

declare @jack float;

set @jack = (select sum(id)+sum(salaire) from student)

PRINT @jack;