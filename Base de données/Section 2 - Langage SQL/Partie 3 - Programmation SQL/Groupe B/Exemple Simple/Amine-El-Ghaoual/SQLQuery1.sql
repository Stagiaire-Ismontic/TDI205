/* deaclaration et utilisation variable */
    DECLARE @x INT ;
    DECLARE @y INT ;
	  SET @x=10;
	  SET @y=20;

 IF (@x > 0)
   BEGIN
     IF (@x < @y)
         select 'x > 0 and x < y';
     ELSE
        select 'x > 0 and x >= y';
    END 
 SELECT
    CASE
	WHEN @x<@y THEN 'X inferieur a Y'
	WHEN @x>@Y  THEN 'no valide'
END
   
