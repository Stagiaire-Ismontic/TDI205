
Declare @num int
Declare ModifierN
Cursor for
	Select T.Id_Tache from Tache T
Open ModifierN
Fetch ModifierN into @num
While @@FETCH_STATUS=0
Begin
  DECLARE  @Nom1 VARCHAR(200)= (SELECT P.Titre FROM Projets P INNER JOIN Tache T ON P.Id_Projets=T.Projets_Id where Id_Tache=@num);
  DECLARE  @Nom2 VARCHAR(200)= (SELECT T.Titre FROM Projets P INNER JOIN Tache T ON P.Id_Projets=T.Projets_Id where Id_Tache=@num);
  DECLARE  @NomComplete VARCHAR(200)= @Nom1+''+@Nom2;
  update Tache Set Titre =@NomComplete where Id_Tache=@num;
  Fetch ModifierN into @num
End
Close ModifierN
Deallocate ModifierN

Select * from Tache