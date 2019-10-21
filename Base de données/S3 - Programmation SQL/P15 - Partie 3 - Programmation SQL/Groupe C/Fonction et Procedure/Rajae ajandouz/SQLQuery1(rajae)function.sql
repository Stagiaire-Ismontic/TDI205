create function dbo.rajae()
returns int 
as
begin
declare @r int
declare @a int
declare @s int
set
@r=5
set 
@a=12
set
@s=@r+@a
return @s
end 

print dbo.rajae()
