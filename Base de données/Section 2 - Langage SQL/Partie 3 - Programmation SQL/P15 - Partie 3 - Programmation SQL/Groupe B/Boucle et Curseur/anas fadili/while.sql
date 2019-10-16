DECLARE @counter INT = -5;
 
WHILE (@counter <= 5)
BEGIN
    PRINT @counter;
    SET @counter = @counter + 2;
END