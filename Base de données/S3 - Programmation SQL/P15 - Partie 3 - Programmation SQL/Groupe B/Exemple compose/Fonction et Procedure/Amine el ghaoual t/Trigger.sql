create database EX_Triggerr;
create table product(id int not null,qte int not null,prix int not null);

create trigger mytrigger on product

instead of insert 
as 
begin 
print 'product succefuully'
end
insert into product values(1,100,3000)
select * from product

