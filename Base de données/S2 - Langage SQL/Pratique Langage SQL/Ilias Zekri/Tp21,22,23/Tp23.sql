Create Function Statistique1(@Id_Projets int)
returns @Statistique1 Table(Code Varchar(50),Titre Varchar(255),Nombre int)
as
Begin
Declare @NombreTaches int
Declare @NomProjet Varchar(255)
Select @NomProjet=Titre from Projets Where Id_Projets=@Id_Projets
Select @NombreTaches=COUNT(*) from Projets p,Tache t where t.Projets_Id=p.Id_Projets
insert into @Statistique1 values('Nom_Projets et Nombre des taches du Projets'+@NomProjet,@NombreTaches)
return
end



Create Function Statistique2(@Id_Projets int)
returns @Statistique2 Table(Code Varchar(50),Titre Varchar(255),Nombre int)
as
Begin
Declare @NombreStagiaires int
Declare @NomProjet Varchar(255)
Select @NomProjet=Titre from Projets Where Id_Projets=@Id_Projets
Select @NombreStagiaires=COUNT(*) from Projets p inner join Tache t On t.Projets_Id=p.Id_Projets inner join TachesStagiaires Ts on t.Id_Tache=Ts.Tache_Id inner join Stagiaires S on Ts.Stagiaire_Id=S.Id_Stagiaires
insert into @Statistique2 values('Nom_Projets et Nombre des Stagiaires'+@NomProjet,@NombreTachesStagiaires)
return
end
