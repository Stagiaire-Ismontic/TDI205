/*Tp 21: creation de fonction scalaire*/
create function NombreTaches (@projet_id int)
returns int
as
begin
declare @nombre_tache int
select @nombre_tache = COUNT(*) from Taches where @projet_id = @projet_id;
return @nombre_tache
end

select id,titre, dbo.NombreTaches(id) as "nombre des taches" from Projets;

