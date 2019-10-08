--Select simple--
Select * from Projet;
--Select entre deux tables--
Select p.nombre_jr_réalisation,p.titre, t.nbr_jr_réalisatioin 'nbr_jr_réalisatioin de tache' ,
t.titre as 'titre de tache' from Projet p inner join Tâche t on p.idProjet=t.idprojet
--select entre plusieur tablle--
Select p.nombre_jr_réalisation,p.titre, t.nbr_jr_réalisatioin 'nbr_jr_réalisatioin de tache' ,
t.titre as 'titre de tache', s.nom as 'Nom e stagiare', s.cin,s.date_naissance from Projet p inner join Tâche t on p.idProjet=t.idprojet
inner join TacheStagiare ta on ta.idTach=t.idTach
inner join Stagiares s on s.idStag=ta.idStag