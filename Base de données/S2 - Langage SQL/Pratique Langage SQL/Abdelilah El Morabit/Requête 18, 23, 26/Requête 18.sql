create table stagiariers(id int,
nom varchar(50),
note_bac float,
filiere varchar(50),
id_groupe int,
 constraint n_note check(note_bac between 0and 20),
 check(filiere='tdi' or filiere='tri'),
 constraint pk_stagiaire_groupe foreign key(id_groupe) references Groupes(id)
 );
