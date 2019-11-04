alter Function GrandProjet(@Nombre_Jours_Min int)
returns Table
as
return Select * from Projets Where Nombre_Jours_Realisation>@Nombre_Jours_Min


alter Function PS(@Id_Stagiaire int)
returns Table
as
return Select * from Projets P inner join Taches T on P.id=T.projet_id 
	inner join TachesStagiaires Ts on Ts.stagiaire_id=@Id_Stagiaire



