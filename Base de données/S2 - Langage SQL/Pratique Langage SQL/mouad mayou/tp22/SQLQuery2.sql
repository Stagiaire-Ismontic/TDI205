create function GrandProjets(@nombre_jours_min int)
returns Table 
as
 return (select * from Projets where nombre_jours_realisation > @nombre_jours_min)