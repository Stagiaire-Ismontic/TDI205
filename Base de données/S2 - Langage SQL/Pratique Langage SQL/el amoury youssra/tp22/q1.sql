
create function GrandProjets(@nombre_jours_min int)
returns table
as
return(select *from projet where nombre_jour_realisation>@nombre_jours_min)
