create database Exelmple_Compose_TRIGGER;

create table Product( id int not null, qte int not null,prix int not null);

--Trigger
create trigger Mytrigger on Product

instead of insert ---KAT ENI excute ead insert f tab u kayn after
as
begin
print 'Product has been successfully added'

end
insert into Product values(2,150,2000)
select * from Product