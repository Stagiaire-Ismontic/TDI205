begin transaction Modification
save transaction p1
update Stagiaires set nom='A' where id=1;
save transaction p2
update Stagiaires set nom='B' where id=1;
rollback transaction p2
commit transaction Modiction