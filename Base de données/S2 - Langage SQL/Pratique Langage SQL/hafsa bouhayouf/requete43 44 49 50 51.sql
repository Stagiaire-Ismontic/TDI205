alter table Stagiaires add Prenom varchar(100);
Select Nom,Prenom, note_bac from Stagiaires ORDER BY note_bac ASC;
Select Nom,Prenom, note_bac from Stagiaires ORDER BY note_bac DESC;
select MAX(note_bac) as nmax from Stagiaires;
Select ville,max(note_bac) as nmax From Stagiaires GROUP BY ville;
Select Ville , max(note_bac) as nmax From Stagiaires GROUP BY ville
HAVING max(note_bac) > 15;