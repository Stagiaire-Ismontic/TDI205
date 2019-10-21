DECLARE @ToSquare INT
DECLARE @Square INT
SET @ToSquare = 0
WHILE @ToSquare < 100
BEGIN
    SET @ToSquare = @ToSquare + 1
    SET @Square = @ToSquare * @ToSquare
    IF @Square < 500
        CONTINUE
    IF @Square > 1000
        BREAK
    PRINT @Square
END