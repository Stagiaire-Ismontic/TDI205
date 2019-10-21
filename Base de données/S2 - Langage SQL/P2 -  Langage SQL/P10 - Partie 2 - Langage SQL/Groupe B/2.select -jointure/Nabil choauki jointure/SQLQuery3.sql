select p.id,p.titre,t.projet_id,r.tache_id from Projets p
 inner join Taches t on p.id=t.projet_id inner join  TachesStagiaires   r on t.id=r.tache_id;