select s.idStag as 'Identifiant',s.prenom+' '+s.nom 
as 'Nom complet',p.titre as 'Nom de Projet'
 from Stagiares s inner join TacheStagiare ts on ts.idStag=s.idStag 
 inner join Tâche t on t.idTach=ts.idTach 
 inner join Projet p on p.idProjet=t.idprojet 