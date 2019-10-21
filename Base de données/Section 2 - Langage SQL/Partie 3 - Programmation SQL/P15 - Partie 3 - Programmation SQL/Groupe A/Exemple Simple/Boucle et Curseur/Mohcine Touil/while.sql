DECLARE @Iteration INT
SET @Iteration = 1
WHILE @Iteration < 11
BEGIN
    PRINT @Iteration
    SET @Iteration = @Iteration + 1
END