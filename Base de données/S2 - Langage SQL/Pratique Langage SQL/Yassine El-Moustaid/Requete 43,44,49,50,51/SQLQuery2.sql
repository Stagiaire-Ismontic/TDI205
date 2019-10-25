insert into Stagiaires(id,nom,filiere,note_bac) values(1,'Anas','tdi',15);
insert into Stagiaires(id,nom,filiere,note_bac) values(2,'Amine','tri',16);
insert into Stagiaires(id,nom,filiere,note_bac) values(3,'Aymane','tri',10);
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(4,'Az','tdi',16,'tanger');
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(5,'Kesh','tdi',15,'Marrakesh');
insert into Stagiaires(id,nom,filiere,note_bac,ville) values(5,'Kech','tri',10,'Marrakesh');

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
