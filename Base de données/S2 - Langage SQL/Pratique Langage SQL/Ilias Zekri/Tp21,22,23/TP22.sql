Create Function GrandProjet(@Nombre_Jours_Min int)
returns Table
as
	return (Select * from Projets Where Nombre_Jours_Realisation>@Nombre_Jours_Min)






Create Function PS(@Id_Stagiaire int)
returns Table
as
	return (Select * from Projets P inner join Tache T on P.Id_Projets=T.Projets_Id 
	inner join TachesStagiaires Ts on Ts.Stagiaire_Id=@Id_Stagiaire)
