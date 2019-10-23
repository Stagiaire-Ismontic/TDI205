declare @err_msg varchar(100), @err_state int, @err_num int;
declare @b int,@a int;
set @a=2;
set @b=8;

begin try;
print @b/@a;
end try
begin catch
select
@err_msg = ERROR_MESSAGE(),@err_state = Error_state(),@err_num = error_number();
end catch;