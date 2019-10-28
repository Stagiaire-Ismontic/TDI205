/*requete18*/
create table Groupes(id int,nom varchar(50),constraint pk_groupe Primary key(id));
Create table stagiaires(
id int,
nom varchar(50),
note_bac float,
prenom varchar(50),
filiere varchar(50),
ville varchar(50),
id_groupe int,
Constraint n_note Check(note_bac between 0 and 20),
Check(filiere='tdi'or filiere='tri'),
Constraint pk_stagiaire Primary key(id),
Constraint fk_stagiaire_groupe Foreign key(id_groupe) References
Groupes(id)
);
/*requete23*/
alter table stagiaires alter column ville varchar(100)not null;
/*requete26*/
create table Mention(
id int identity(1,2),
nom varchar(50),
nmax float,
nmin float);
/*requete43*/
Insert into stagiaires (id,nom,prenom,note_bac,filiere,ville)
values (1,'loubna','anouja',15,'tdi','tanger'),(2,'hicham','laghmich',14,'tri','casa');
select nom,prenom,note_bac,filiere from stagiaires ORDER BY note_bac ASC;
/*requete44*/
select nom,prenom,note_bac,filiere from stagiaires ORDER BY note_bac DESC;
/*requete49*/
select MAX (note_bac) as NoteMaximum from stagiaires;
/*requete 50*/
Select Ville , max(note_bac) as NoteMax From stagiaires GROUP BY ville
/*requete 51*/
Select Ville , max(note_bac) as NoteMax From stagiaires GROUP BY ville
HAVING max(note_bac) > 10 ;
/*requete 52*/
create table employe(num int,nom varchar(20),ville_emp varchar(50),salaire int);
Insert into employe (num,nom,ville_emp,salaire)
values (1,'loubna','tanger',5000),(2,'hicham','casa',8000),(3,'nada','rabat',7000),(3,'lolo','tanger',2000);
Select * From employe where salaire =(select MAX(salaire) From
employe) ;
/*requete 53*/
Select * from employe where salaire IN (Select MAX(salaire) 
as SalaireMax from employe GROUP BY ville_emp) ;
/*requete 54*/
Select * From employe where salaire> ANY(Select MAX (salaire) from
employe GROUP BY ville_emp) ;
/*requete 55*/
Select * From employe where salaire< All(select MAX (salaire) from
employe GROUP BY ville_emp) ;
/*requete 58*/
Create VIEW ListeStagiaires as Select nom, id from stagiaires ;
/*requete 59*/
Create index index_nom on stagiaires(nom);