declare @titre_Tache as nvarchar(50);
declare @titre_projets as nvarchar(50);
declare @tache_titre as nvarchar(50);

set @titre_Tache=( select titre from Taches where id=1);
set @titre_projets=( select titre from Projets where id=1);
set @tache_titre=@titre_Tache+@titre_projets;
print 'le titre '+@tache_titre;



