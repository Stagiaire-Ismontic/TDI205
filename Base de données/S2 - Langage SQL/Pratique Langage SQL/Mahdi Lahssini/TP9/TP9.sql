declare @nombre_jour int;
select @nombre_jour = DATEDIFF(day,date_fin,date_debut) from TachesStagiaires 
print @nombre_jour;


declare @nom_et_prenom nvarchar(200);
select @nom_et_prenom= nom+' '+ prenom from Stagiaires where nom='ninja';
print @nom_et_prenom;