declare @a int set @a=10;
select
case
	when @a<0 then print 'negative';
	when @a>0 then print 'negative';
	else
end