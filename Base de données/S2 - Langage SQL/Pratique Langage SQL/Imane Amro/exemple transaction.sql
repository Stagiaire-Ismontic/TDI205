Begin Transaction Modification
save Transaction p1
Update Stagiaires set nom='A' where id=1;
save Transaction p2
Update Stagiaires set Nom='B' where id=1;
Rollback Transaction p2
Commit Transaction Modification 