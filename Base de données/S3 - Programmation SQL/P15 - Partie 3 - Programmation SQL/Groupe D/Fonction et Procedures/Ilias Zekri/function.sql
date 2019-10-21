create function SumEl (@x int,@y int)
returns int
begin
declare @ss int
set @ss=@x+@y
return @ss
end

print dbo.SumEl(5,10)

