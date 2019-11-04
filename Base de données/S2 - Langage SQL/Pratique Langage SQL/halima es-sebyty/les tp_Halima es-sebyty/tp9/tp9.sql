declare @nombre_jour int;
select @nombre_jour =sum(day(date_fin - date_debut)) from TachesStagiaires;
print @nombre_jour;

declare @nom_et_prenom nvarchar(200);
select @nom_et_prenom=nom+''+prenom from Stagiaires where nom='Madani'
print 'nom et prenom'+ @nom_et_prenom;