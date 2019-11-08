Select * from Employe where salaire IN (Select MAX(salaire) 
as SalaireMaxfrom Employe GROUP BY ville) ; 