/*Question 1*/
create procedure AjusteNombreJours(@id_tache int)
as
begin
	if not exists (select * from taches where @id_tache=taches.id)
	begin
		print 'id incoorect';
		return;
	end
	ELSE
	begin
		update taches set nbj_relisation = (select AVG(DATEDIFF(DAY,date_debut,date_fin)) from TachesStagiaires 
		where tache_id=@id_tache) where taches.id=@id_tache;
	end
end
select * from taches;
