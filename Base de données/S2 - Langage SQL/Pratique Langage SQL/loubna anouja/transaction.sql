Begin Transaction Modification
save Transaction p1
Update stagiaire set nom='A' where id=1;
save Transaction p2
Update stagiaire set Nom='B' where id=1;
Rollback Transaction p2
Commit Transaction Modification