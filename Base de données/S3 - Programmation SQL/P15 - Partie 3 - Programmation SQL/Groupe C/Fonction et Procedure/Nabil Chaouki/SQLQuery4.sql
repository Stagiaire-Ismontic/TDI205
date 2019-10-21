create function linux()
returns int 
as 
begin 
declare @sm int
declare @var1 int;
declare @var2 int
set 
@var1=5
set
@var2=10
set
@sm=@var1+@var2
return @sm
end