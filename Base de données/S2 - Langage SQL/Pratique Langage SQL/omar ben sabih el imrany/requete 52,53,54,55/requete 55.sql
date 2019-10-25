Select * From Employé where salaire< All(select MAX (salaire) from
Employé GROUP BY ville) ;