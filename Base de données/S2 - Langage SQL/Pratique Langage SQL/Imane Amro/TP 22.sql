
--question 1
create function GrandProjets(@nombre_jours_min int)
returns table
as
return (select * from projets where nombre_jours_realisation>@nombre_jours_min);

--question 2
create function ProjetsStagiairess(@id_stagiaire int)
returns table
as
return (select * from projets where id in (select projet_id from taches where id in (select tache_id from TachesStagiairees where stagiaire_id = @id_stagiaire) ) );


