Select Ville , max(note_bac) as NoteMax From Stagiaires GROUP BY
ville HAVING max(note_bac) > 15 ; 