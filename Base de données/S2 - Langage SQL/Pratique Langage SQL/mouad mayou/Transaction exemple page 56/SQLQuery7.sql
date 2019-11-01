Begin Transaction Modification  
save Transaction p1 
 Update stg set Nom='A' where id=1;
 save Transaction p2
 Update stg set Nom='B' where id=1;
 Roll back Transaction p2
 Commit Transaction Modification 