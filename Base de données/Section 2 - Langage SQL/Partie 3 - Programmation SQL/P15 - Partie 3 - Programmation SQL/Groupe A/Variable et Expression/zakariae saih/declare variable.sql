declare @var int;
declare @var2 int;
declare @var3 int;

set @var = 7;
set @var2 = 3;
set @var3 = @var + @var2;

print @var3;

print getdate();

create table student(
	id int,
	salary int,
	name varchar(33)
);

insert into student values(7, 1000, 'jack');
insert into student values(1, 1700, 'jass');

declare @jack = (select sum(id) + sum(salary) from student);

print @jack;
