create procedure printAddition( @nbr1 int,@nbr2 int)
 as print @nbr1 + @nbr2

 create function  returnAddition(@nbr1 int ,@nbr2 int)
 returns int
 begin 
 return @nbr1+@nbr2
 end