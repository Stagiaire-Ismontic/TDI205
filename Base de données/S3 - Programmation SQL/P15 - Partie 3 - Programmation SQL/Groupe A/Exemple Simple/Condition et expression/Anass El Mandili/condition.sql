 DECLARE @Test INT ;
 SET @Test=100;
	  

BEGIN
   IF (@Test >= 100)
         selecT @Test;
   ELSE
        select  'false';
END 

SELECT
  CASE
 WHEN @Test >= 100 THEN 'correct'
ELSE 
   'incorrect'
END
   
   