select p.id,p.titre,t.Projets_id,ts.stagiqre_id from Projets p
inner join Taches t on p.id=t.Projets_id
inner join TachesStagiare ts on t.id=ts.tache_ide;