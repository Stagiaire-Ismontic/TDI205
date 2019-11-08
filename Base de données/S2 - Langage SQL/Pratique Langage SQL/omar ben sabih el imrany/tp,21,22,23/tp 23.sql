Create Function Stat1(@id_projet int)
returns @Stat1 Table(Code Varchar(50),Titre Varchar(255),Nombre int)
as
Begin
Declare @numtache int
Declare @nomprojet Varchar(255)
Select @nomprojet=titre from Projets Where id=@id_projet
Select @numtache=COUNT(*) from Projets p,Taches t where t.id=p.id
insert into @Stat1 values('Nom_Projets et Nombre des taches du Projets'+@nomprojet,@numtache)
return
end



Create Function Stat2(@id_projet int)
returns @Stat2 Table(Code Varchar(50),Titre Varchar(255),Nombre int)
as
Begin
Declare @Numstagiaire int
Declare @nomprojet Varchar(255)
Select @nomprojet=Titre from Projets Where id=@id_projet
Select @Numstagiaire=COUNT(*) from Projets p inner join Taches t On t.id=p.id inner join TachesStagiaires Ts on t.id=Ts.Tache_Id inner join Stagiaires S on Ts.stagiaire_id=S.id
insert into @Stat2 values('Nom_Projets et Nombre des Stagiaires'+@nomprojet,@numstagiaire)
return
end
