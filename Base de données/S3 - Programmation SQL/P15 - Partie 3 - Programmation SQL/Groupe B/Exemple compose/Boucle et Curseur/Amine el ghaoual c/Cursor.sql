create database gg
use gg
create table t_auteurs
(
auteur_nom varchar(50)
)
insert into t_auteurs values('amine')




DECLARE curseur_auteurs CURSOR FOR
	SELECT auteur_nom FROM t_auteurs
 DECLARE @nom VARCHAR(50)='';
OPEN curseur_auteurs;
 
FETCH curseur_auteurs INTO @nom;
 
WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @nom
	FETCH curseur_auteurs INTO @nom
END
 
CLOSE curseur_auteurs
DEALLOCATE curseur_auteurs