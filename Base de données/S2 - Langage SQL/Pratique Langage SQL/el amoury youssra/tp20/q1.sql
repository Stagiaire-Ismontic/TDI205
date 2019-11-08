Create procedure Corruiger as begin
declare @id_projet int 
declare curseur1 cursor for select p.id_projet from projet p
open curseur1
fetch curseur1 into @id_projet

while(@@FETCH_STATUS=0)
begin
declare @sum int

select @sum =SUM(t.nombre_jour_realisation_tache) from taches t inner join projet p on t.id_projet=p.id_projet where p.id_projet=@id_projet
update projet set nombre_jour_realisation=@sum
where id_projet=@id_projet
fetch curseur1 into @id_projet
end
close curseur1
end
