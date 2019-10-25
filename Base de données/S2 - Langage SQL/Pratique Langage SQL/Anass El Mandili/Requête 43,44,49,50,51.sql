insert into Stagiaire(id,nom,note,filière) values(1,'ahmed',15,'tdi');
insert into Stagiaire(id,nom,note,filière) values(2,'ali',9,'tri');
insert into Stagiaire(id,nom,note,filière,ville) values(3,'ali',17,'tri','tanger');
insert into Stagiaire(id,nom,note,filière,ville) values(4,'ali',11,'tri','tanger');
insert into Stagiaire(id,nom,note,filière,ville) values(5,'ali',10,'tdi','fes');


--Requete 43
Select nom, note, filière from Stagiaire ORDER BY note; 
--Requete 44
Select nom, note, filière from Stagiaire ORDER BY note DESC; 
--Requete 49
select MAX(note) as NoteMaximum from Stagiaire; 
--Requete 50
Select ville , max(note) as NoteMax From Stagiaire GROUP BY ville 
--Requet 51
Select ville , max(note) as NoteMax From Stagiaire GROUP BY ville HAVING max(note) > 15 ; 