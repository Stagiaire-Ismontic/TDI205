declare curseur1 cursor for select titre,id_projet from projet
declare @t1 varchar(50)
declare @id int
open curseur1
fetch curseur1 into @t1,@id
while(@@FETCH_STATUS=0)
begin
update taches set titre_tache+=@t1 where id_projet=@id
print @id
print @t1
fetch curseur1 into @t1,@id
end
close curseur1
deallocate curseur1
select * from taches;