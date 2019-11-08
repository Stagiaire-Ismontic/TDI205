
insert into Groupes values(1,'amine')
insert into Groupes values(2,'grp2')
insert into Stagiaires values(1,'amine',15,'tdi',1,'tanger')
insert into Stagiaires values(2,'anas',10,'tri',2,'tetouan')


/*Requête 43 : Affichage de toues stagiaires avec ordre croissant des notes*/
select nom,note_bac,filier from Stagiaires order by note_bac ASC;
/*Requête 44 : Affichage de toues stagiaires avec ordre décroissante des notes*/
select nom,note_bac,filier from Stagiaires order by note_bac DESC;
/*Requête 49 : Afficher la note maximale de tous les stagiaires */
select MAX(note_bac) as NoteMaximum from Stagiaires;
/*Requête 50 : Afficher les notes maximums de toutes les villes */
Select Ville , max(note_bac) as NoteMax From Stagiaires GROUP BY ville
/*Requête 51 : Afficher les notes maximums supérieures à 10 de toutes les villes en utilisation de « Having »*/
Select Ville , max(note_bac) as NoteMax From Stagiaires GROUP BY ville HAVING max(note_bac) > 15;