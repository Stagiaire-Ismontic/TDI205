insert into options(montant,typee,id  ) values('5000','kkk',1)
select *from options;
begin transaction;
delete from options where id=1;
update options set montant=5000-500 where id=1;
save transaction v;