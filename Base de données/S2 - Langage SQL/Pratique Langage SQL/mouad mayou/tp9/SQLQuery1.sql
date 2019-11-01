declare @nombre_jour int
select @nombre_jour = Datediff(day,[date_debut] ,[date_fin]) from tachesStagiaires;
print @nombre_jour 


declare @nom_et_prenom varchar(500)
select @nom_et_prenom= nom +' '+ prenom from Stagiaires where nom='Madani'
print @nom_et_prenom