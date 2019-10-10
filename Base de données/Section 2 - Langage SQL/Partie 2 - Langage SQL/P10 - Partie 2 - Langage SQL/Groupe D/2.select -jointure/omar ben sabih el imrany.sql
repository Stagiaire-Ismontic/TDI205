insert into projets(id_projet,titre) values(1,'evaluation');
select * from projets;
select a.id_projet,a.titre,t.projets.id_projet from projets a.inner join taches t On a.id = t.id_projet;
select b.id_projet,b.titre,t.projets.id_projet , ts.id_tache from projets inner join 
taches On b.id_projet = ts.id_tache inner join tachestagiaires ts on t.id_tache =ts.id_tache;