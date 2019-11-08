Create Function GrProjet(@num_jour_mini int)
returns Table
as
	return (Select * from Projets Where Nombre_Jours_Realisation>@num_jour_mini)






Create Function PS(@id_stagiaire int)
returns Table
as
	return (Select * from Projets P inner join Taches T on P.id=T.id
	inner join TachesStagiaires Ts on Ts.stagiaire_id=@id_stagiaire)
