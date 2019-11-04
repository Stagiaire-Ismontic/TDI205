create function Statistiques( @projet_id int)
returns @statistique table(code varchar(50),titre varchar(255),nombre int)
as 
begin
declare @nombreTache int
declare @nombreStagiaire int
declare @nomProjet varchar(255)
select @nomProjet = titre from Projets where id=@projet_id
select @nombreTache  =count(*) from Projets,Taches
where Taches.projet_id =Projets.id
insert into @statistique values('Nombre_Taches','Nombre des taches du projet'+@nomProjet,@nombreTache)
return 
end
/*pour afficher les resultas du fonction*/
select code,titre ,nombre,Statistiques(2) from Projets;




 

