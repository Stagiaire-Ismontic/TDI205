
create database NOTES;

create table students(id int primary key not null  ,moy int );

DECLARE @somme int;
set @somme=(select sum(id)+sum(moy) from students);
print @somme;

insert into students values(1,14);
insert into students values(2,16);
select * from students;