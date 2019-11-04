create trigger Trig on Projets
for  insert 
as
begin
print 'You added successfuly'
end
create trigger Trig on Projets
instead of  delete 
as
begin
if((select COUNT(*)from Projets)>2)
print 'Deleting successfuly'
else
print 'Deleting fail'
rollback tran
end

delete from Projets 