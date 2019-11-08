Create procedure Corriger2
as
Begin
declare Cr cursor 
for select id from Taches
declare @id int, @somme int
open Cr
fetch Cr into @id
while(@@FETCH_STATUS=0)
begin
select @somme=(select sum(datediff(day,date_debut,date_fin))from TachesStagiaires where tache_id=@id)
update Taches set Nombre_Jours_Realisation=@somme where id=@id
fetch Cr into @id
end 
close Cr
deallocate Cr
end