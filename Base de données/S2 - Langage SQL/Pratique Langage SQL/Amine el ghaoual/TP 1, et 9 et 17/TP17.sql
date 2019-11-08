/* Tp 17 */
declare cur1 cursor for select titre,id from Projets
declare @t1 varchar(50)
declare @id int 
open cur1
fetch cur1 into @t1,@id
while(@@FETCH_STATUS=0)
begin 
update Taches set titre=titre+@t1 where projet_id=@id
print @id
print @t1
fetch cur1 into @t1,@id
end
close cur1
deallocate cur1
select * from Taches