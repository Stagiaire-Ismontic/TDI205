/* Tp 21: creation d'une fonction scalaire */

create function NombreTaches(@projet_id int)
returns int
as begin
	declare @nombre_tache int
	select @nombre_tache =count(*) from Taches
	where projet_id=@projet_id;

	return @nombre_tache
end

select id,titre,dbo.NombreTaches(id) as "Nombre des taches" from Projets;

/* Tp 22: fonction table en ligne*/
--Quest1
create function GrandProjets(@nombre_jours_min int)
returns table
as
	return (select * from Projets where nombre_jours_realisation > @nombre_jours_min)
--Quest2

create function ProjetsStagiaires(@id int)
returns table
as
return ( select * from projets)

/* Tp23 */

create function statistiques (@projet_id int)
returns @statis table(code varchar(30),titre varchar(100),nombre int)
as
begin
declare @nombreTache int;
declare @nombreStagiaire int;
declare @nomProjets varchar(30);
select @nomProjets = titre from projets where id=@projet_id;
select @nombreTache=count(*) from taches where taches.projet_id=@projet_id;
insert into @statis values('nombre_taches',/**/concat('nombre des taches du projets ',@nomProjets),@nombreTache)
return
end
--Q 1
select * from statistiques(2);
--Q 2
create function statistiques2 (@projet_id int)
returns @statis table(code varchar(30),titre varchar(100),nombre int)
as
begin
declare @nombreTache int;
declare @nombreStagiaire int;
declare @nomProjets varchar(30);
select @nomProjets = titre from projets where id=@projet_id;
select @nombreTache=count(*) from taches where taches.projet_id=@projet_id;
select @nombreStagiaire=count(*) from Stagiaires where id in (select distinct stagiaire_id from TachesStagiares where tache_id in (select id from taches where projet_id=@projet_id));
insert into @statis values('nombre_taches',/**/concat('nombre des taches du projets ',@nomProjets),@nombreTache)
insert into @statis values('nombre_Stagiaire',/**/concat('nombre des taches du projets ',@nomProjets),@nombreStagiaire)
return
end
drop function statistiques2;
select * from statistiques2(1);
