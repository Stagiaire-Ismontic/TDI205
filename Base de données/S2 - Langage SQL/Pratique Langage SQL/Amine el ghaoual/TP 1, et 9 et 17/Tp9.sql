insert into Stagiaires values(1,'nom1','prenom1','k10000','tanger','1996','aaa@gmail.com',061111111,0622222222)
insert into Projets values(1,'tit1',4)
insert into Taches values(1,'titr1',1,3)
insert into TachesStagiaires values(1,1,'12/06/2019','10/07/2020')

declare @nombre_jour int
select @nombre_jour = datediff(day,date_debut,date_fin) from TachesStagiaires;
print @nombre_jour

declare @nom_et_prenom nvarchar(100)
select @nom_et_prenom = nom+ ' ' + prenom from Stagiaires where nom='nom1';
print @nom_et_prenom
 
 select* from TachesStagiaires

 drop table TachesStagiaires