--Question 1
create trigger insertion on TachesStagiaires
for insert 
as
declare @insertedValue int =(select tache_id from inserted);
exec AjusteNombreJours @id_tache= @insertedValue;

--Question2

create trigger corriger on Taches
for insert,update
as
declare @insertedValue int =(select projet_id from inserted);
exec AjusteNombreJoursPro @id_projet= @insertedValue;
