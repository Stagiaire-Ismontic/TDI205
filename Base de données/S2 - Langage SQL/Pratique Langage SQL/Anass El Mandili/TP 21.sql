--TP 21
create function NombreTaches(@Projet_id int) 
returns int
as
begin
	declare @nombre_tache int
	select @nombre_tache = count(*) from Taches where projet_id = @nombre_tache
	return @nombre_tache
end


