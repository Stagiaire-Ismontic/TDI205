create function nombreTaches(@projets_id int)
returns int
as
begin
declare @nombre_tache int;
select @nombre_tache = count(*) from taches
where projet_id = @projets_id;

return @nombre_tache
end

select id,titre,dbo.nombreTaches(id) as "Nombre des taches" from projets;