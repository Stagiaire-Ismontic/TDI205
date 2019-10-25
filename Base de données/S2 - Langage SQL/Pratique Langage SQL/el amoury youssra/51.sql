select ville ,max(note) as NoteMAx from stagiaires group by ville
having max(note)>15;