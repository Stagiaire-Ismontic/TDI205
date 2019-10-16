declare @a int set @a=20;

IF @a<20
BEGIN
    print cast(@a as varchar) + '<20'
END
ELSE
BEGIN
    print cast(@a as varchar) + '>=20'
END