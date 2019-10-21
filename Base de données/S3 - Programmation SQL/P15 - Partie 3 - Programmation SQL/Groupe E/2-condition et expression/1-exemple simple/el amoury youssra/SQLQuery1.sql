/*condition et expressin*/
declare @q int;
set @q=100;
begin
if(@q>=100) select @q;
else
select 'false';
end
/*select case*/
select case
when @q>=100 then 'correct'
when @q<=100 then 'correct'
end 