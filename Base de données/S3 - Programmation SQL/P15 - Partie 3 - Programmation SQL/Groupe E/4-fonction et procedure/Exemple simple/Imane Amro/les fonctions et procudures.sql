CREATE PROCEDURE print_addition( @nmbr1 int,@nmbr2 int)
as print @nombr1+@nmbr2;
create function return_addition(@nmbr1 int ,@nmbr2 int)
returns int
begin
return @nmbr1+@nmbr2;
end
