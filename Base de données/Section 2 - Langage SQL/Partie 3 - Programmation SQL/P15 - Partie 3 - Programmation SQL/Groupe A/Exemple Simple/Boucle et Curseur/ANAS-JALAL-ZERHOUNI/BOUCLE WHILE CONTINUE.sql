declare @i int;
set @i = 0;

while @i <10
BEGIN
	set @i = @i +1;
	if @i =5
		CONTINUE

	print @i;

END