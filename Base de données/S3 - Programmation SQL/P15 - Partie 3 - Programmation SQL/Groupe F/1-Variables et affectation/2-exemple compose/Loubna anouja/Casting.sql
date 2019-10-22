create table students(
	id int identity,
	nom varchar(30)
);

insert into students(nom) values ('coco3oo');

select CAST(id as varchar(30)),nom from students;
