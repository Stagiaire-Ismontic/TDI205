declare @nombre int=5, @i int=0;
/*la boucle*/
while(@i<=0)
begin
print cast(@nombre as char(1))+'*'+cast(@i as char(2))+'='+cast(@nombre * @i as char(2))
set @i+=1;
end
