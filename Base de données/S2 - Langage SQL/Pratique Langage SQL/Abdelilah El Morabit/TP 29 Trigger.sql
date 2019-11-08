--Q 1
create trigger insertion on TachesStagiares
for insert 
as
declare @insertedValue int =(select tache_id from inserted);
exec AjustementNombreJours1 @id_tache= @insertedValue;

--Q 2
create trigger InsertOuModifTaches on taches
for insert,update
as
declare @insertedValue int =(select projet_id from inserted);
exec AjustementNombreJours @id_projet= @insertedValue;

