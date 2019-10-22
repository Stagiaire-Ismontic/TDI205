create table stagiaire(nomS varchar(20));
insert into stagiaire values('youssra');

DECLARE @nom VARCHAR(50);
set @nom='';
print @nom;
 
DECLARE stagiaire_cursor CURSOR FOR
	SELECT nomS FROM stagiaire ;
 
OPEN stagiaire_cursor;
 
FETCH stagiaire_cursor INTO @nom;
 
WHILE @@FETCH_STATUS = 0
BEGIN
if @nom!='youssra'
begin
	PRINT @nom;
	FETCH stagiaire_cursor INTO @nom;
	end
END
 
CLOSE stagiaire_cursor;
DEALLOCATE stagiaire_cursor;