CREATE FUNCTION return_multiplication (@nombre1 INT, @nombre2 INT)
	RETURNS INT
	BEGIN 
		RETURN @nombre1 * @nombre2
	END
