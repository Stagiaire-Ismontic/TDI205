create database Exelmple_Compose_TRIGGER;

create table Product( id int not null, qte int not null,prix int not null);

create function GetProduct()
returns Table
return (select * from Product)

drop function GetProduct

--function qui retorne le tableau
create function dbo.GetProduct(@id int,@qte int,@prix int)

returns @AnotherOne table(Id int ,Qte int ,Prix int )
begin
insert into @AnotherOne values(@id,@qte,@prix)
return
end

select * from dbo.GetProduct(1,21,23)

--Trigger


create trigger Mytrigger on Product

instead of insert ---KAT ENI excute ead insert f tab u kayn after
as
begin
print 'Product has been successfully added'

end
--insert into Product values(2,150,2000)
drop table Product
select * from Product