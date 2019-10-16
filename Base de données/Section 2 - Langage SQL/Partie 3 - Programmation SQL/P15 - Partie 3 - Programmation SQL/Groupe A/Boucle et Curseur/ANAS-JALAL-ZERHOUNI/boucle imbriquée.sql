declare @i int;
set @i = 0;

while @i <=10
BEGIN
	set @i = @i +1;
	declare @j int;
	set @j=0;
	while @j<=10
	begin
		set @j = @j +1;
		print cast(@j as varchar) + '+' + cast(@i as varchar) + '=' + cast((@i * @j) as varchar)
	end
END