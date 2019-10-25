Select * from Employé where salaire IN (Select MAX(salaire) as
SalaireMax from Employé GROUP BY ville) ;