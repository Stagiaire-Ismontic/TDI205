create table T1(
id int primary key,
name varchar(20) 
)

insert into T1 values (1,'name_1'),(2,'name_2'),(3,'name_3')

select Cast(id as varchar)+' ' + name from T1