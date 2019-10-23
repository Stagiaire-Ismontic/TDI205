declare
@error_message nvarchar(4000),
@error_severity int,
@error_state int;

begin try
Raiserror('error lh',17,1);
end try
begin catch
select
@error_message =error_message(),
@error_severity=error_severity(),
@error_state=error_state();
select @error_message,@error_severity,@error_state;
end catch


