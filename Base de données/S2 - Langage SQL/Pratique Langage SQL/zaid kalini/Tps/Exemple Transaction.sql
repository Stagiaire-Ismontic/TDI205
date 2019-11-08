

Begin Transaction Modification
save Transaction p1
Update Employé set ville='Tanger' where (select max(salaire) from Employé)=5000;
save Transaction p2
Update Employé set Nom='' where salaire=0;
Rollback Transaction p2
Commit Transaction Modification
Select*from Employé