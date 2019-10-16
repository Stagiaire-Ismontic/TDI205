create database Gestp
use Gestp

create table projet
(
 id int primary key,
 note float,
)

insert into projet values(2,5)
select * from projet

DECLARE @somme int
SET @somme=(select sum(id)+ sum(note) from projet)
PRINT @somme


DECLARE @Age int;
SET @Age=18;
print @Age;

PRINT GETDATE();

