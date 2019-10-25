Create table Groupe( id int primary key, nom varchar(50));
Create table Stagiaire( id int, nom varchar(50), note_bac float, filiere varchar(50),
 id_groupe int, Constraint n_note Check(note_bac between 0 and 20), Check(filiere='tdi'or filiere='tri'),
 Constraint pk_stagiaire Primary key(id),
 Constraint fk_stagiaire_groupe Foreign key(id_groupe) References Groupe(id));

Create index index_nom on Stagiaire(nom);