create function NombreTaches(@projet_id int)
returns int 
as
begin 
declare @nombre_tache int 
select @nombre_tache = COUNT(*) from taches
where id_projet=@projet_id;
return @nombre_tache
end
