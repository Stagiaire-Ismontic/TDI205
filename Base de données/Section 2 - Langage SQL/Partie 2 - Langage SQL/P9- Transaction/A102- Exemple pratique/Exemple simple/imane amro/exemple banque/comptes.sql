insert into comptes(num ,dt  , id ) values (555, '12/09/2014',2)
select * from comptes; 
begin transaction;
delete from comptes  where id=2;
commit;