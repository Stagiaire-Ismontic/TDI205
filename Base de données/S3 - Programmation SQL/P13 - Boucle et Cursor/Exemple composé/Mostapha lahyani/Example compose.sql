create table auteur(auteur_nom varchar(20));

DECLARE @nom VARCHAR(50);
set @nom='';
print @nom;
 
DECLARE select_auteur_cursor CURSOR FOR
	SELECT auteur_nom FROM auteur ;
 
OPEN select_auteur_cursor;
 
FETCH select_auteur_cursor INTO @nom;
 
WHILE @@FETCH_STATUS = 0
BEGIN
if @nom!='madani'
begin
	PRINT @nom;
	FETCH select_auteur_cursor INTO @nom;
	end
END
 
CLOSE select_auteur_cursor;
DEALLOCATE select_auteur_cursor;