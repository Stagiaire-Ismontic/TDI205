create table tachesStagiaires(stagiaire_id int ,tache_id int ,primary key(stagiaire_id,tache_id),date_debut date,date_fin date,
foreign key(stagiaire_id)references Stagiaires(id),foreign key(tache_id)references taches(id));
