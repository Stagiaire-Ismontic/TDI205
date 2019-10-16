create table cc(
id int primary key,
nom varchar(20),)
declare @i int=0;
while(@i<=5)
begin
set @i=@i+1;
insert into cc values(@i,'nom'+convert(varchar,@i));
end;