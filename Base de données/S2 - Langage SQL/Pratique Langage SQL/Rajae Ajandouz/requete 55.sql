Select * From Employe where salaire< All
(select MAX (salaire) from Employe GROUP BY ville) ;