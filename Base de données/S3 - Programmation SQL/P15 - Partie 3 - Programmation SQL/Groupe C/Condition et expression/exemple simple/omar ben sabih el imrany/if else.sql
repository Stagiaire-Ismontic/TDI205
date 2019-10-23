declare @c int;
set @c =2;

select 
 case @c
 when 1 then 'A'
 when 2 then 'b'
 else'ereur'
 end
 declare @r1 varchar(20)='omar';
 declare @r2 varchar(20)='nabil';
 if @r1=@r2
 select @r1;
 else select @r2;
