select a.id,a.titre,t.proje_id from projets a inner join taches t on a.id=t.proje_id inner join tachesStagiaires ts on t.id=ts.tache_id;