
begin try
	declare @a int,@b int , @c int;
	raiserror('Imposible to do the division',1,2);
end try
begin catch
	select error_message();

	
end catch;
