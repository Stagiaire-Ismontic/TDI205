begin transaction Modification
save transaction p1
update stagiaires set nom='a' where id=1;
save transaction p2
update stagiaires set prenom='youssra' where id=1;
Rollback transaction p2
commit transaction Modification