select * from projets
select * from taches
insert into taches([id],[titre],[projet_id],[nombre_jours_realisation]) values (3,'tantan',2,15);
update taches  set titre='titre 1';

declare cursname cursor 
for select t.id, p.titre from projets p inner join taches t on t.projet_id=p.id
declare @titrep varchar(30) = '';
declare @id_tache int;
open cursname
fetch next from cursname into @id_tache,@titrep;
while @@FETCH_STATUS =0
begin 
update taches  set titre+=@titrep where id =  @id_tache
fetch next from cursname into @id_tache,@titrep;
end
close cursname;
deallocate cursname;