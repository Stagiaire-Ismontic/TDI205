create function GrandProjtes(  @nombre_jours_min int)
returns table
as 
return(select *from Projets where @nombre_jours_realisation >@nombre_jours_min)
GrandProjtes(@nombre_jours_min)
 create function ProjetsStagiaires(@Stagiaire int)
 returns table
 as 
 return (select *from Stagiaires where id =@Stagiaire)
ProjetsStagiaires(id);