Select Ville , max(Note_bac) as NoteMax From Stagiaires GROUP BY ville
HAVING max(Note_bac) > 15 ;