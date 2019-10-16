--declaration avec l'affectation des variable
DECLARE @loop INT
SET @loop = 1
--boucle while
WHILE @loop <= 10
BEGIN
    PRINT @loop
    SET @loop = @loop + 1
END
