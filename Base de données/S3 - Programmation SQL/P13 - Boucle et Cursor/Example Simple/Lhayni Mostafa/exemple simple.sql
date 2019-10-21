/*
declare les variables
while (condition)
begin
//instruction
variable local

incriment/stop
end
*/

declare @nombre int = 4, @i int = 0;
while(@i<= 10)
begin
	print cast(@nombre as char(1))+ '*' +cast(@i as char(2)) + '=' +
	cast(@nombre * @i as char(2))
	set @i=@i+1;
end