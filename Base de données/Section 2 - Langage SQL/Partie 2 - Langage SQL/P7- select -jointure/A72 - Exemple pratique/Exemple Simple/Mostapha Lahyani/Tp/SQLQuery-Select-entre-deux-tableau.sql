select p.id,p.titre,p.nombre_jours_realisation,T.projet_id from Projets p
inner join Taches T on p.id = T.projet_id 