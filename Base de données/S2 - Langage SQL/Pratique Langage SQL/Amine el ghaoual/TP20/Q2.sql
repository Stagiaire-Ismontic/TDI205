/*Question 2*/
create procedure AjusteNombreJoursPro(@id_projet int)
as
begin 
	if not exists (select * from projets where @id_projet=projets.id)
	begin
		print 'id incorrect';
		return;
	end
	else
	begin
		UPDATE projets set nbrj_realisation=(select SUM(nbj_relisation) from taches where taches.projet_id=@id_projet) where projets.id=@id_projet;
	end
end

select * from projets