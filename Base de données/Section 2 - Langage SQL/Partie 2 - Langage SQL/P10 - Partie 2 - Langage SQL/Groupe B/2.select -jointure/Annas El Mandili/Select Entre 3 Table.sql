select P.id,P.titre,T.Projet_id,Ts.tache_id from Projets P inner join Taches T on P.id = T.Projet_id
inner join TachesStagiaire Ts on T.id = Ts.tache_id;