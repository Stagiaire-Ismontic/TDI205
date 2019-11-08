create function nombreTaches(@projet_id int)
returns int 
as
begin
 declare @nombre_tache int
  select @nombre_tache=COUNT(*) from taches
   where projet_id=@projet_id;
   return @nombre_tache
end
select id,titre,dbo.nombreTaches(id) as "nombre des taches " from Projets;