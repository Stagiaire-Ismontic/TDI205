/*reaquete 43*/
select nom,id_groupe,note_bac from stagiaire order by note_bac ASC;

/*reaquete 44*/

select nom,id_groupe,note_bac from stagiaire order by note_bac DESC;

/*reaquete 49*/

select MAX(note_bac) as NoteMaximum from stagiaire; 

/*reaquete 50*/
   Select ville , max(note_bac) as NoteMax From stagiaire GROUP BY ville ;

/*reaquete 51*/

Select Ville , max(note_bac) as NoteMax From stagiaire GROUP BY ville HAVING max(note_bac) > 15 ; 
