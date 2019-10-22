
begin try
	declare @a int,@b int , @c int;
	--set @a =0 ;set @b = 0;set @c = @a/@b;
	raiserror('Imposible de faire la division',1,2);
end try
begin catch
	select error_message();

	
end catch;
