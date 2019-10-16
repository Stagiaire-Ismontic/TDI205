declare @var int;
set @var=100;
Begin
    if(@var>=100)
	select @var;
	else 
	   select 'false';
end
  
  select 
  case 
  when @var>=100 then 'correct'
  when @var<=100 then 'incorrect'
  end