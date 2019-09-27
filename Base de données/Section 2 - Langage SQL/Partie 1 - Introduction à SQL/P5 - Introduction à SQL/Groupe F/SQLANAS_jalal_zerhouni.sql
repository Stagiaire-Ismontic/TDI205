SELECT * FROM Projets;

INSERT INTO Projets(ID,titre,Nombre_jours_realisation)
	VALUES (3,'EtyM',13);

INSERT INTO Taches(ID,titre,Projets_Id,Nombre_jours_realisation)
	VALUES (3,'EtyM',2,13);

INSERT INTO Stagiaires(id,nom,prenom,cin,date_naissance,tel_fix,tel_portable)
	VALUES (1,'hamid','kamim','k152563','2000/07/19',0666666,0785466);

	INSERT INTO Taches_stagiaires(Stagiaire_Id,taches_id,date_fin)
	VALUES (3,5,'2019/08/19');

SELECT * FROM Stagiaires;


