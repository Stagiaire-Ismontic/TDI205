DECLARE @pow INT
DECLARE @pow2 INT
SET @pow= 0
WHILE @pow < 10
BEGIN
    SET @pow = @pow + 1
    SET @pow2 = @pow * @pow
    IF @pow2 > 100
        BREAK
    PRINT @pow2
END