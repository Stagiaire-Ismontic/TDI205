/*creation procedur simple*/
create procedure print_addition(@nb1 int,@nb2 int)
as print @nb1+@nb2
/*cretion d'une fonction simple*/
Create function return_addition(@nb1 int,@nb2 int)
returns int
begin
return @nb1+@nb2
end