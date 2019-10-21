DECLARE @pow INT
DECLARE @pow2 INT
SET @pow = 0
WHILE @pow < 100
BEGIN
    SET @pow = @pow + 1
    SET @pow2 = @pow * @pow
    IF @pow2 < 100
        CONTINUE
    IF @pow2 > 1000
        BREAK
    PRINT @pow2
END