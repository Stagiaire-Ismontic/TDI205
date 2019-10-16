Create Table Table1(Num int)
declare @Count int=1
while @Count<=5
begin
	insert into Table1 values (@Count)
	set @Count=@Count+1;
end
select*from Table1