select t.titre + ' ' + p.titre from Taches t inner join Projets p on p.id = t.id
declare @str varchar(100)
declare @cpt int=1
update Taches set titre=@str where id = @cpt