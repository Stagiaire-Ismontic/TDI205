DECLARE @ToSquare INT
DECLARE @Square INT
SET @ToSquare = 0
WHILE @ToSquare < 10
BEGIN
    SET @ToSquare = @ToSquare + 1
    SET @Square = @ToSquare * @ToSquare
    IF @Square > 100
        BREAK
    PRINT @Square
END