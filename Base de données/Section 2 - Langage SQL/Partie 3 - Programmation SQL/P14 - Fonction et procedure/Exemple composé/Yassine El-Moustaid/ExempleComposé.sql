create database ExempleCompose;
/* creation function qui retourne table */
create function dbo.RetTable(@name varchar(20),@Lastname varchar(20),@age int)

returns @monTab table(nom varchar(20),prenom varchar(20),Age int)

begin 

insert into @monTab values(@name,@Lastname,@age)

return

end

select * from dbo.RetTable('Yassine','ElMoustaid',21)

/*Trigger*/

create table produit(nom varchar(30),id int)

create trigger test_trigger on produit

instead of insert
as
begin
insert into produit values ('Yassine',15)
print 'ta ajouté le produit avec succes'

end
insert into produit values ('test',20)

drop trigger test_trigger

/*alter trigger test_trigger on produit

instead of insert
as
begin
insert into produit values ('Yassine',15)
print 'ta ajouté le produit avec succes'
select * from inserted
end
insert into produit values ('test',20)*/
select * from produit
delete from produit 

