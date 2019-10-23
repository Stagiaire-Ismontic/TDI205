declare @a int;
declare @b int;
	set @a=2;
	set @a=5;
if(@a > 0)
BEGIN
	if(@b > 0)
		print 'a>0 and a<b';
	else
		print 'a>0 and a>=b';
end