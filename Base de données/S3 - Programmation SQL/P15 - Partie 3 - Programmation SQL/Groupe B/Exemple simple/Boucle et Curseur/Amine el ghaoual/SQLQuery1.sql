DECLARE @a int=1,@j int=0;
while (@j<=10)
BEGIN
PRINT cast(@a as char(1))+'-'+cast (@j as char(2))+'='+cast(@a+@j as char(2));
set @j+=1
END
