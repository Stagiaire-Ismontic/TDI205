
CREATE TABLE TestTable (cola int, colb char(3));

--Déclaration et utilisation d'une variable:
DECLARE @MyCounter int;
set @MyCounter=0;

print @MyCounter;
--Instruction While:
WHILE (@MyCounter < 26)
BEGIN;

   INSERT INTO TestTable VALUES

       (@MyCounter,
        CHAR(( @MyCounter + ASCII('a')))
       );

   SET @MyCounter = @MyCounter + 1;
END;

SELECT *FROM TestTable;


