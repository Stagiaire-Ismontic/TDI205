Create proc Corriger2
as
Begin
declare Cur cursor 
for select Id_Tache from Taches
declare @Id int, @Somme int
open Cur
fetch Cur into @Id
while(@@FETCH_STATUS=0)
begin
select @Somme=(select sum(datediff(day,Date_Debut,Date_Fin))from TachesStagiaires where Tache_Id=@Id)
update Taches set Nombre_Jours_Realisation=@somme where Id_Tache=@id
fetch Cur into @Id
end 
close Cur
deallocate Cur
End