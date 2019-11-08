Create Function NombresTaches(@Id_Projets int)
returns int
as
Begin
	Declare @NombreTaches int;
	Select @NombreTaches=COUNT(*) from Taches where @Id_Projets=projet_Id;
	return @NombreTaches
End

Select Id_Projets,Titre,dbo.NombresTaches(1) as NombreTaches from Projets P 