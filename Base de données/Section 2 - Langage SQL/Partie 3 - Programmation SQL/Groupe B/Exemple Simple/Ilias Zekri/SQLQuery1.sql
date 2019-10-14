DECLARE @Num1 varchar(30)='ilias'
DECLARE @Num2 varchar(30)='ilias'
DECLARE @Test int
SET @Test = 1
SELECT
Case @Test
WHEN 1 THEN IF @Num1=@Num2 SELECT @Num1 ElSE SELECT @Num2 
WHEN 2 THEN DECLARE @Num3 varchar(30)='Zekri' SELECT @Nun3
ElSE 'Error'
END
