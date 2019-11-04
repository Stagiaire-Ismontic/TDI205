create function NombreTaches(@projet_id int)
returns int
as
begin
 declare @nomre_Tache int
 select @nombre_Tache = count(*) from Taches where @projet_id =@projet_id ;
 return @nombre_Tache
 end

 select id,titre dbo.NombreTaches(id) as 'Nombre des Taches' from Projets