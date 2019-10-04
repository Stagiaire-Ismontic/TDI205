insert into  Projetss values (1,'SIMPLE1',3),
 (2,'SIMPLE2',3),
 (3,'SIMPLE3',3),
 (4,'SIMPLE4',3),
 (5,'SIMPLE5',3);
 delete from Projetss where titre like '%%'
 select * from Projetss

 alter table Tachess
 add constraint pk_tachess_projetss FOREIGN KEY (id)
 references Projetss (id)
 on update cascade 
 on delete cascade


  alter table TachesStagiaires
 add constraint pk_TachesStagiaires_tachess FOREIGN KEY (stagiaire_id)
 references tachess (id)
 on update cascade 
 on delete cascade



  alter table TachesStagiaires
 add constraint pk_TachesStagiaires_Stagiaires FOREIGN KEY (stagiaire_id)
 references Stagiaires (id)
 on update cascade 
 on delete cascade

