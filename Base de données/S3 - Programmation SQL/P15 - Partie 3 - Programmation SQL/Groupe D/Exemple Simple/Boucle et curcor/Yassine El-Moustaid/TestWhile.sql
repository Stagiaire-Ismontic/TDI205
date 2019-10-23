create database Khobza;

create table testKhobza (var1 int, var2 char(3));

/*declaration des variables */
DECLARE @myFeran int;
set @myFeran=0;

print @myFeran;
/* boucle while*/
WHILE (@myFeran < 26)
BEGIN;

   INSERT INTO testKhobza VALUES

       (@myFeran,CHAR(( @myFeran + ASCII('a'))));

   SET @myFeran = @myFeran + 1;
END;

SELECT *FROM testKhobza;


