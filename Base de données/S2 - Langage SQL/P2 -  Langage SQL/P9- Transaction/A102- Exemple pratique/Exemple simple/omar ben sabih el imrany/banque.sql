insert into banque(nom,patente,adresse) values('bcp',280708,'al boughaz');
select * from banque;
begin transaction;
delete from banque where patente=280708;
commit;