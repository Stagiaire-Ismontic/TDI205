--question 1
create trigger insertion on TachesStagiairees
for insert 
as
declare @insertedValue int =(select tache_id from inserted);
exec NombreJours1 @id_tache= @insertedValue;

--test
insert TachesStagiairees values(7,1,'2019-05-01','2019-05-05');


--question 2
create trigger InsertOuModifTaches on taches
for insert,update
as
declare @insertedValue int =(select projet_id from inserted);
exec NombreJours @id_projet= @insertedValue;

