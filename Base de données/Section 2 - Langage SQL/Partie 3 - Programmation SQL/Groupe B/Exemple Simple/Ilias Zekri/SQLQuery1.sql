DECLARE @Nom1 varchar(30)='ilias'
DECLARE @Nom2 varchar(30)='ilias'
DECLARE @Test int
SET @Test = 1
SELECT
Case @Test
WHEN 1 THEN 'Correcte'
WHEN 2 THEN 'incorecte'
ElSE 'Error'
END
IF @Nom1=@Nom2 SELECT @Nom1 ELSE SELECT @Nom2