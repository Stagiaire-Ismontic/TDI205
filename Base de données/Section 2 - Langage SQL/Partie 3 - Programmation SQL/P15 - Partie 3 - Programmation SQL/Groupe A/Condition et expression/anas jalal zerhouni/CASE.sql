 DECLARE @Test INT ;
 SET @Test=-100;
	  
SELECT
  CASE
 WHEN @Test < 0 THEN 'negative'
ELSE 
   'positive'
END
   
   