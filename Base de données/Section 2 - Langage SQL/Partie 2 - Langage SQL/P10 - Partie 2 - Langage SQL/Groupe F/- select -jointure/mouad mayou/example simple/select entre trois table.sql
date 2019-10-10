select P.id ,P.titre,T.Projets_id,tache_id from Projets P 
inner join Taches T on P.id = Projets_id
inner join TachesStagiaires Ts on T.id=tache_id;
