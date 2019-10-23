go
create table client( id int,nom nvarchar(30));
insert into client values(1,'ahmed');
insert into client values(2,'Mostapha');
insert into client values(3,'mohamed');
select * from client;
/* trigger data manipulation language*/
go
 create TRIGGER EX1 ON client
 INSTEAD OF INSERT, UPDATE 
 AS BEGIN 
 SELECT * from client;
 END
 DROP TRIGGER EX1
 GO
 CREATE TRIGGER EX2 ON client
 FOR INSERT, UPDATE 
 AS BEGIN 
 SELECT * from client;
 END
  INSERT INTO client VALUES(4,'Mokhtar');
  DROP TRIGGER EX2
 GO
 CREATE TRIGGER EX3 ON client
 AFTER INSERT, UPDATE 
 AS BEGIN 
 SELECT * from client;
 END
  INSERT INTO client VALUES(5,'MAHMOUD');
  



