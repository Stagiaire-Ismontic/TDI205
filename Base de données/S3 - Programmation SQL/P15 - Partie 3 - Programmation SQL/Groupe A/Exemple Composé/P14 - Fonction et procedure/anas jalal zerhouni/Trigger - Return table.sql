create database Exelmple_Compose;



create table Product(id int,Nome varchar(30));

--return table 

create function GetProduct(@id int,@Nome varchar(30))

returns @AnotherOne table(Id int ,nome varchar(30))
begin
insert into @AnotherOne values(@id,@Nome)
return
end

select * from dbo.GetProduct(1,'anas')

--Trigger

create trigger Mytriggerni on Product

for insert /*after instead of*/
as
begin

print 'Product has been successfully added'

end

drop trigger Mytriggerni
insert into Product(id,Nome) values(2,'anas');
select * from Product