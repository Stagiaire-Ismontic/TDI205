create table auteur(nom_auteur varchar(20))
declare @nom varchar(50);
set @nom='';
print @nom;
declare select_auteur_cursor cursor for
select nom_auteur from auteur;
open select_auteur_cursor;
fetch select_auteur_cursor into @nom;
while @@FETCH_STATUS=0
begin 
if @nom!='ss'
begin 
print @nom;
fetch select_auteur_cursor into @nom;
end 
end
close select_auteur_cursor;
deallocate select_auteur_cursor;