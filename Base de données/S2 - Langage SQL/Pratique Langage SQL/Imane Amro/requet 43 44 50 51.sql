insert into stagiaires(id,nom,prenom,note_bac,ville)
values (1,'imane','amro',17,'tanger'),
(2,'walid','azalmad',18,'fes'),
/*requet 43*/
Select nom,prenom, note_bac from stagiaires ORDER BY note_bac ASC;
/*requet 44*/
Select nom,prenom, note_bac from stagiaires ORDER BY note_bac DESC;
/*requet 49*/
select MAX(note_bac) as NoteMaximumfrom from Stagiaires; 
/*requet 50*/
Select ville , max(note_bac) as NoteMax From Stagiaires GROUP BY ville 
/*requet 51*/
Select ville , max(note_bac) as NoteMax From Stagiaires GROUP BY ville HAVING max(note_bac) > 15 ; 