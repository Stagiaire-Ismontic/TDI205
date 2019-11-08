/*question2*/
select id_projet,titre,dbo.NombreTaches(id_projet) as "nombre de taches" from projet;