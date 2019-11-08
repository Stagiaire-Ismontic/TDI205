create proc corrigee
as
begin
Declare @Id_Projets int
Declare Cursor1 Cursor for Select P.Id_Projets from Projets P
Open Cursor1
Fetch Cursor1 into @Id_Projets
While @@FETCH_STATUS=0
Begin
	Declare @Sum int

    Select @Sum = Sum(T.Nombre_Jours_Realisation) from Tache T 
	inner join Projets P on T.Projets_Id=P.Id_Projets 
	Where p.Id_Projets=@Id_Projets

	update Projets set Nombre_Jours_Realisation=@Sum Where Id_Projets=@Id_Projets

	Fetch Cursor1 into @Id_Projets
End
Close Cursor1
Deallocate Cursor1
end
Select * from Projets