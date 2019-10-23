Create Table Test(id int ,nom varchar(30))
insert into Test values(1,'ilias'),(2,'zekri')
Create Trigger TestTri on Test
after insert 
as
begin
	declare @t int=(select te.id from Test te where te.nom='ilias')
	if @t=1 delete from Test where id=@t  
end
insert into Test values(3,'zzzz')
select*from Test