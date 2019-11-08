declare @nombre_jour int
select @nombre_jour=SUM((DAY(date_fin) - DAY(date_debut))) from tachesStagiaires
print @nombre_jour