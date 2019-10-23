declare @test float
declare TestCu1 cursor for 
select salary from tb_Cursor
open TestCu1
fetch TestCu1 into @test
while @@FETCH_STATUS=0
begin
if(@test =(select max(Salary)from tb_Cursor))
insert into maxSal values(@test)
fetch TestCu1 into @test
end
close TestCu1
DEALLOCATE TestCu1
select * from maxSal
delete from maxSal