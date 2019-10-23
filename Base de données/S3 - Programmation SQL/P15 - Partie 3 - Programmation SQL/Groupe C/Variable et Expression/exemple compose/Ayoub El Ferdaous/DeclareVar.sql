declare @x varchar(10)
declare @y int 


set @x = '12'

set @y = CAST(@x as int )

print @y
