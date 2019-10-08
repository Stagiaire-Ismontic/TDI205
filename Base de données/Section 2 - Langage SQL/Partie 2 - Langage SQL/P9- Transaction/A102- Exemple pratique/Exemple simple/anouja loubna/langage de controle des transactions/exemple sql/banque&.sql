insert into Client(nom_client,prenom_client,adress_client,Id_client) values ('mohammed','ali','birchifa',1)
select * from Client;
begin transaction;
delete from Client where Id_client=1;
rollback;
select * from Client;
