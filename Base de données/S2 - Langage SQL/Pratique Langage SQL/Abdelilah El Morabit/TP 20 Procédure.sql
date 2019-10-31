--Question 1
create procedure AjustementNombreJours(@id_tache int)
as
begin
	if not exists (select * from taches where @id_tache=taches.id)
	begin
		print 'id n exsist pas';
		return;
	end
	ELSE
	begin
		update taches set nombre_jours_realisation = (select avg(datediff(day,date_debut,date_fin)) from TachesStagiares where tache_id=@id_tache) where taches.id=@id_tache;
	end
end

AjustementNombreJours 3

select * from taches;
--Question 2
create procedure AjustementNombreJoursPro(@id_projet int)
as
begin 
	if not exists (select * from projets where @id_projet=projets.id)
	begin
		print 'id n exsist pas';
		return;
	end
	else
	begin
		update projets set nombre_jours_realisation=(select sum(nombre_jours_realisation) from taches where taches.projet_id=@id_projet) where projets.id=@id_projet;
	end
end

AjustementNombreJoursPro 1

select * from projets;