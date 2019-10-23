Create Table Test1(sal int);
insert into Test1 values(12),(13),(14)
declare @test int
declare TestCu cursor for 
select sal from Test1
open TestCu
fetch TestCu into @test
while @@FETCH_STATUS=0
begin
select @test
fetch TestCu into @test
end
close TestCu
DEALLOCATE TestCu
select * from Test1
