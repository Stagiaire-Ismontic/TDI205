DECLARE @Num1 varchar(30)='ilias'
DECLARE @Num2 varchar(30)='ilias'
DECLARE @Test int
SET @Test = 1
SELECT
Case @Test
WHEN 1 THEN 'Correcte'
WHEN 2 THEN	'incorecte'
ElSE 'Error'
END
IF @Num1=@Num2 SELECT @Num1 ELSE SELECT @Num2