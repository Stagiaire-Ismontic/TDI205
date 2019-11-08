declare @nombre_jour int
select  @nombre_jour= sum(DAY(date_fin-date_debut)) from TachesStagiaires;
declare @nom_prenom nvarchar(200)
select @nom_prenom= nom+'imane'+prenom from Stagiaires where nom ='madani'
print @nom_prenom
