create trigger T on Projets for  insert 
as
begin
print 'ajout reussi';
end
create trigger T on Projets instead of  delete 
as
begin
if((select COUNT(*)from Projets)>2)
begin
print 'suppression reussi';
end
else
begin
print 'supression échoué';
rollback tran
end

delete from Projets;