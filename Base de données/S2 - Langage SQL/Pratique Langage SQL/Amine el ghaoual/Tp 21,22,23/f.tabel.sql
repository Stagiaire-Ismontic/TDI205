/*TP 22 : Fonction Table en lign*/
create function GranProjets(@nombre_jours_min int)
returns table
as 
return (select * from Projets where nbrj_realisation >@nombre_jours_min)


create function ProjetsStagiares(@id int)
returns table
as
return (select * from Projets)