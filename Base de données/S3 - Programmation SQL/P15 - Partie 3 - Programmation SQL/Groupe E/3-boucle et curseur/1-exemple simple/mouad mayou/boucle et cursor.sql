declare @nbr int,@i int;
set @nbr=5;set @i=0;

while(@i<=10)
begin 
print cast(@nbr as char(1))+'*'+cast(@i as char(2))+'='+cast(@nbr *@i as char(2))
set @i+=1;
end

