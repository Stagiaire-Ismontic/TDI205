create table students(
	id int identity,
	nom varchar(30)
);

insert into students(nom) values ('moahmed');

select CAST(id as varchar(30)),nom from students;
