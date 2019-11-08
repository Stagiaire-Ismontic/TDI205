insert into Stagiaires(id,nom,filiere,note_bac) values(1,'zaka','tdi',19);
insert into Stagiaires(id,nom,filiere,note_bac) values(2,'mestafa','tdm',13);
insert into Stagiaires(id,nom,filiere,note_bac) values(3,'Aymane','tri',12);
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(4,'Azdin','tdi',16,'tanger');
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(5,'Kesh','tdm',15,'rabat');
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(5,'Kech','tri',10,'casa');

select distinct nom from Stagiaires;

select * from Stagiaires;

/*requete 43*/
select id,nom,filiere,note_bac from Stagiaires Order by note_bac ASC;

/*requete 44*/
select id,nom,filiere,note_bac from Stagiaires Order by note_bac DESC;

/*requete 49*/
select Max(note_bac) as NoteMax from Stagiaires;
/*requete 50*/
select ville,max(note_bac) as NoteMax from Stagiaires Group by ville;
/*requete 51*/
select ville,max(note_bac) as NoteMax from Stagiaires group by ville having max(note_bac)>15;
