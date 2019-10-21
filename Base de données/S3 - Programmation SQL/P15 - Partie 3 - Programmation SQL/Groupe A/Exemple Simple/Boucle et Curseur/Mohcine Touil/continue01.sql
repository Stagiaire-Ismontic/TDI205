DECLARE @ToSquare INT
SET @ToSquare = 0
WHILE @ToSquare < 10
BEGIN
    SET @ToSquare = @ToSquare + 1
    IF @ToSquare = 5
        CONTINUE
    PRINT @ToSquare
END