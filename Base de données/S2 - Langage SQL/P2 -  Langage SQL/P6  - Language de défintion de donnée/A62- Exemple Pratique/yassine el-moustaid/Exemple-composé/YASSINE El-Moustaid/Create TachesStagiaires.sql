create table TachesStagiaires(stagiaire_id int,tache_id int, primary key(stagiaire_id,tache_id),date_debut date,date_fin date);

alter table TachesStagiaires add foreign key (stagiaire_id) references Stagiaires(id);

alter table TachesStagiaires add foreign key (tache_id) references taches(id);
