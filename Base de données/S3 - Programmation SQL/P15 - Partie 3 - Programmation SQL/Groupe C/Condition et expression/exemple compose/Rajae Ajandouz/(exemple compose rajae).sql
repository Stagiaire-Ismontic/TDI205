declare @Error_Message varchar(300), @Error_state int , @error_Number int
declare @a int, @c int 
set @a=8 
 set @c=2
 begin try 
 print   @a/@c
 end try 
 
 begin catch
 select 
 @Error_Message =Error_Message(),
 @Error_state= Error_state()
 @error_Number =Error_Number();

end catch 