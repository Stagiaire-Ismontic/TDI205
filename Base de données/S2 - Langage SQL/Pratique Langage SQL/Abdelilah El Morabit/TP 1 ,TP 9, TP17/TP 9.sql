declare @Nombre_Jour int ;
select @Nombre_Jour =DATEDIFF(day,date_debut,date_fin) from tachesStagiaiers;
print @Nombre_Jour;



declare @nom_et_prenom nvarchar(200);
select @nom_et_prenom = nom + ' ' + prenom from stagiaire where nom = 'madani';
print @nom_et_prenom;