go 
create table client(id int,nom varchar(30));
insert into client values(1,'ahmed');
insert into client values(2,'mostapha');
insert into client values(3,'madani');

select *from client;

/*trigger data manipulation language*/
go

create trigger ex1 on client 
instead of insert ,update 
as begin
 select * from client;
 end
 insert into client values (4,'mokhtar');
 drop trigger ex1
 go 
 create trigger ex2 on client
 for insert ,update
 as begin
 select *from client;
 end 
 insert into client values (4,'mokhtar');
 drop trigger ex2
 go 
 create trigger ex3 on client 
after insert ,update 
as begin
 select * from client;
 end
 insert into client values (5,'mokhtar');
 drop trigger ex3
