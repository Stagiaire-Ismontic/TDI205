DECLARE @nb1 int ;
DECLARE @nb2 int ;

  set @nb1=2;
  set @nb2=4;

if(@nb1>0)
BEGIN

  if(@nb1>@nb2)
     
	   select 'nb1 >nb2';
   Else
       select 'nb1 <nb2';

END


select 
  CASE
    WHEN @nb1 > @nb2 THEN 'nb1 Supperieur a nb2'
    WHEN @nb1 < @nb2 THEN 'nb1 inferieur a nb2'
END