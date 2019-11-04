--TP 20
create procedure corrige
as
begin
declare @id_projets int
declare cursor1 cursor for select p.id from projets p
open cursor1
fetch cursor1 into @id_projets
while @@FETCH_STATUS=0
begin
declare @Sum int
select @Sum=sum(t.nombre_jours_realisation) from taches t inner join projets p on t.projet_id=p.id where p.id=@id_projets
update projets set nombre_jours_realisation=@Sum where @id_projets=@id_projets
fetch cursor1 into @id_projets
end
close cursor1
end
deallocate cursor1
