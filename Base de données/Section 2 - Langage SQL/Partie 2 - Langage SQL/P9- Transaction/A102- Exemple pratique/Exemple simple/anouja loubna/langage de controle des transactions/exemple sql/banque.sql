insert into Operation(Montant,type,Id_operation) values (5000,'dh',1);
select * from Operation;
begin transaction;
delete from Operation where Id_operation=1;
update Operation set Montant=5000-500 where Id_operation=1 ;
save transaction er;