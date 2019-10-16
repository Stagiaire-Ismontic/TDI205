
declare @Count int=0
while @Count<5
begin
	insert into Ca values (@Count)
	set @Count=@Count+1;
end
