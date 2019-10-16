


 declare @a int , @b int,@sum int;
 set @sum = 2 + 3;
 print @sum;


CREATE PROCEDURE print_addition @nbre1 INT, @nbre2 INT
AS PRINT @nbre1 + @nbre2


CREATE FUNCTION return_addition (@nbre1 INT, @nbre2 INT)
	RETURNS INT
	BEGIN 
		RETURN @nbre1 + @nbre2
	END