create trigger Trig on eleve
for  insert 
as
begin
print 'You added successfuly'
end
create trigger Trig1 on eleve
instead of  delete 
as
begin
if((select COUNT(*)from eleve)>2)
begin
print 'Deleting successfuly'
delete from eleve
select * from deleted
end
else
print 'Deleting fail'
rollback tran
end

delete from eleve 


insert into eleve values(5555,'zzz',16)