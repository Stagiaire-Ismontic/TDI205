create database ExempleSimple;

<!-- declaration des variable -->
 declare @a int , @b int,@sum int;
 set @sum = 2 + 3;
 print @sum;
 --hgfvfynvtf

<!-- creation d'un procedure simple -->
CREATE PROCEDURE print_addition @nbre1 INT, @nbre2 INT
AS PRINT @nbre1 + @nbre2

<!-- creation d'un function simple -->
CREATE FUNCTION return_addition (@nbre1 INT, @nbre2 INT)
	RETURNS INT
	BEGIN 
		RETURN @nbre1 + @nbre2
	END