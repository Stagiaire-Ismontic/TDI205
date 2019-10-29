declare @nombre_jours_realisation int
select @nombre_jours_realisation = sum(DAY(date_fin - date_debut)) from TachesStagiaires;
print @nombre_jours_realisation;

declare @nom_prenom varchar(50);
select @nom_prenom = nom + ' ' + prenom from Stagiaires where nom = 'Madani';
print @nom_prenom;