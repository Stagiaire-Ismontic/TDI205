create database Exemple;

/* declaration des varibales */

declare @nb1 int , @nb2 int ,@total int;

set @total = 12 + 13;

print @total;


/* creation Procedure simple */ 

create procedure supprimer @var1 int

as print @var1 

/* creation funtion simple */

create function retu_var(@var int , @var2 int)
returns int 
begin 
	
	
	return @var + @var2
	end
	print dbo.retu_var(2,2);
drop function retu_var;