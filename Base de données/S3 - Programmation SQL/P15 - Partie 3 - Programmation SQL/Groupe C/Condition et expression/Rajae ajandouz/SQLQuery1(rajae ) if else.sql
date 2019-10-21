declare @rajae int;
set @rajae =2;

select 
 case @rajae
 when 1 then 'A'
 when 2 then 'b'
 else'ereur'
 end
 declare @r1 varchar(20)='rajae';
 declare @r2 varchar(20)='rajae';
 if @r1=@r2
 select @r1;
 else select @r2;
