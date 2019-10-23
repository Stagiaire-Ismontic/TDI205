DECLARE @nb1 int=7,@i int=0 ;
while(@i<=10)

begin

 print ' nb1 ' + ' + ' + ' i ' + ' = ' +cast(@nb1+@i as char(2));
 set @i+=1;

 end