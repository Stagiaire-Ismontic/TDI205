declare @x int;
declare @y int;
	set @x=10;
	set @y=20;
if (@x > 0)
 BEGIN
   IF (@y > 0)
	select 'x > 0 and x <y';
   else
    select 'x > 0 and x >=y';
 end

 select
   case
   when @x<@y then 'X inferieur a Y'
   WHEN @x>@y then 'NO VALIDE'

