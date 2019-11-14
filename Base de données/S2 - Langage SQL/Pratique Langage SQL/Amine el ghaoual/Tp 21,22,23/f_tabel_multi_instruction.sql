/*TP 23 : Fonction table multi-instructions*/
create function statistique (@projet_id int)
returns @statistique Table (code varchar(50),titre varchar(255),nombre int)
as 
begin
declare @nombreTache int
declare @nombrestagiare int
declare @nomProjet varchar(300)

select @nomProjet = titre from Projets where id  =@projet_id;

select @nombreTache = COUNT(*) from Projets,Taches where Taches.projet_id = Projets.id
insert into @statistique values('nombre_tache','nombre des tache de projet'+@nomProjet,@nombreTache)

return
END
