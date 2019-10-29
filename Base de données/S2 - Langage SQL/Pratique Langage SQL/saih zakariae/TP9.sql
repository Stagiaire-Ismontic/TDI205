create function NomberTaches(@projet_id int)
returns int 
as
begin
   declare @nombre_tache int 
   select @nombre_tache = count(*) from Taches
   where projet_id=@projet_id;
   return @nombre_tache 
   end

