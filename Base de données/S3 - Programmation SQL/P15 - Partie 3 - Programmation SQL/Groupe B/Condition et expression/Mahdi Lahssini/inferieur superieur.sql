    DECLARE @a INT ;
    DECLARE @b INT ;
	  SET @a=50;
	  SET @b=100;


 IF (@a > 0)
   BEGIN
     IF (@a < @b)
         select 'a > 0 and x < b';
     ELSE
        select 'a > 0 and x >= b';
    END 

 SELECT
    CASE
	WHEN @a<@b THEN 'A inferieur a B'
	WHEN @a>@b  THEN 'no valide'
END
   