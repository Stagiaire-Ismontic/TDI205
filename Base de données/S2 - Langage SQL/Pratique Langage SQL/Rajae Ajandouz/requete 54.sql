Select * From Employe where salaire> ANY
(Select MAX (salaire) from Employe GROUP BY ville) ; 