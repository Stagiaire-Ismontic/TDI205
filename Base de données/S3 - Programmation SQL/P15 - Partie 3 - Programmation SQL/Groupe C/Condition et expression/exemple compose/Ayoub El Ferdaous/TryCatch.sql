create procedure Test(@A int,@B int ,@X int output)
as
begin 
 begin try 
    set @X = @A / @B;
	end try
	begin catch 
	SELECT ERROR_MESSAGE() AS ErrorMessage;
end catch
end 

declare @x int

 exec Test 0,0,@x
