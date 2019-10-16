 DECLARE @t INT ;
 SET @t=10;
	  

BEGIN
   IF (@t >= 10)
         selecT @t;
   ELSE
        select  'false';
END 

SELECT
  CASE
 WHEN @t >= 10 THEN 'correct'
ELSE 
   'incorrect'
END
   
   