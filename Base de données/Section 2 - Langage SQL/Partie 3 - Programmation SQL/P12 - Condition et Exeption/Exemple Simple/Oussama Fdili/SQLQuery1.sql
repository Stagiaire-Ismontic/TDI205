declare @num1 int=1;
declare @num2 int=2;
if @num2=@num1
	select @num1;
else
	select @num2;
DECLARE @T int
SET @T = 1
SELECT
Case @Test
WHEN 1 THEN '1'
WHEN 2 THEN '2'
ElSE 'Non'
END