
CREATE PROCEDURE HelloWorld
AS
PRINT 'Hello World'

CREATE FUNCTION helloworldf()
RETURNS varchar(20)
AS 
BEGIN
	 RETURN 'Hello world'
END

declare @var varchar(20)=dbo.helloworldf();

print @var;