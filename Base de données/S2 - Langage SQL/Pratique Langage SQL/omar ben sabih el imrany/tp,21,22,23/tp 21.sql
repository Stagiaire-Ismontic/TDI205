Create Function NumTaches(@Id_Projets int)
returns int
as
Begin
	Declare @NumTaches int;
	Select @NumTaches=COUNT(*) from Taches where @Id_Projets=id;
	return @NumTaches
End

Select id,titre,dbo.NumTaches(1) as NumTaches from Projets P 