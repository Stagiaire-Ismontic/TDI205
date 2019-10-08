select p.id,p.titre,t.Projets_id from Projets p
inner join Taches t on p.id=t.Projets_id;