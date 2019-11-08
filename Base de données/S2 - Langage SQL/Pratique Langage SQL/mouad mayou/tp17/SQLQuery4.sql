declare cursor1 cursor for select titre,id from projets
declare @t1 varchar(50)
declare @id int

open cursor1

fetch cursor1 into @t1,@id
while (@@FETCH_STATUS =0)
begin
 update taches set titre += @t1 where proje_id=@id
 print @id
 print @t1
  fetch cursor1 into @t1, @id 
  end
  close cursor1
  select *from taches