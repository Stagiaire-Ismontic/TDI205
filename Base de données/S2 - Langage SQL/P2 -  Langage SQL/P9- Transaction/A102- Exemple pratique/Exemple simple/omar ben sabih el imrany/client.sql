insert into client(nom,age,cin) values('omar',21,'7474')
select * from client;
begin transaction;
delete from client where cin=7474;
rollback;