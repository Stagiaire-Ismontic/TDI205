select p.id,p.titre,p.nombre_jours_realisation,T.projet_id,ts.stagiaires_id from Projets p
inner join Taches T on p.id = T.projet_id 
inner join TachesStagiairs ts on T.id = ts.tache_id