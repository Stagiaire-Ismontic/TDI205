DECLARE @Val1 INT
DECLARE @Val2 INT
SET @Val1 = 1
WHILE @Val1 <= 10
BEGIN
    SET @Val2 = 1
    WHILE @Val2 <= 10
    BEGIN
        PRINT CONVERT(VARCHAR, @Val1) + ' + ' + CONVERT(VARCHAR, @Val2)
         + ' = ' + CONVERT(VARCHAR, @Val1 + @Val2)
        SET @Val2 = @Val2 + 1
    END
    SET @Val1 = @Val1 + 1
END