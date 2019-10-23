CREATE FUNCTION return_somme (@nbre1 int,@nbre2 int)
returns int 
begin
return @nbre1 + @nbre2
END