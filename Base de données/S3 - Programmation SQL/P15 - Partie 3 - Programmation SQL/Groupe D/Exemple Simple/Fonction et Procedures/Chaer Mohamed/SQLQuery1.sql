create function SumEl (@x int,@y int)
returns int
begin
	return @x+@y
end

print dbo.SumEl(5,10)

