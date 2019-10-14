DECLARE @dd int
set @dd=1;
Select 
case @dd
when 1 then '1'
when 2 then '2'
else 'error'
end

Declare @Num1 varchar(30)='nabil';
Declare @Num2 varchar(30)='houssam';
if @Num1=@Num2
Select @Num1;

else 
Select @Num2;
  

