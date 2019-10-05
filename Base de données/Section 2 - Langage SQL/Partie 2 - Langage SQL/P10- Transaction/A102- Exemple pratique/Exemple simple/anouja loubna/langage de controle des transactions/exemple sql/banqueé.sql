insert into Compte(Num_compte,Id_compte,date_ouverture_compte) values (123456,1,24/04/2012)
select * from Compte;
begin transaction;
delete from Compte where Id_compte=1;
commit;