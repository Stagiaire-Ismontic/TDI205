DECLARE @nb2 int=7,@a int=1 ;
while(@a<=10)

begin

 print cast(@nb2 as char(1)) + ' * ' + cast(@a as char(2)) + ' = ' +cast(@nb2*@a as char(2));
 set @a+=1;

 end