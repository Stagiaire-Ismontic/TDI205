

--Le Cast d'une variable varchar() a une variable int
 declare @Number varchar(5);
 set @Number = '55';
 select cast( @Number as int);