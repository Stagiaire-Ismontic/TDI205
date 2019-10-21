
select *from Projets;

select p.id,p.titre,t.projet_id from Projets p inner join Tache t on p.id=t.projet_id;

select p.id,p.titre,t.projet_id,ts.tache_id from Projets p inner join tache t on p.id=t.projet_id inner join
tache_Stagiaire ts on t.id=ts.tache_id;