Create Proc Corriger1
as
Begin
Declare @id_projet int
Declare Cr Cursor for Select P.id from Projets P
Open Cr
Fetch Cr into @id_projet
While @@FETCH_STATUS=0
Begin
	Declare @somme int

    Select @somme = Sum(T.nombre_jours_realisation) from Taches T 
	inner join Projets P on T.id=P.id
	Where p.id=@id_projet

	update Projets set Nombre_Jours_Realisation=@somme Where id=@id_projet

	Fetch Cr into @id_projet
End
Close Cr
Deallocate Cr
End
