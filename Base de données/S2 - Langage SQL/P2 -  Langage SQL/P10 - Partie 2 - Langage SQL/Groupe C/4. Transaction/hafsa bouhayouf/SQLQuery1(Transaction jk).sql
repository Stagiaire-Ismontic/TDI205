insert into Projets(id ,titre,nombre_jour_real)values(1,'azerty',4)
select *from Projets;
 begin transaction;
 delete from Projets where id=1;
 commit;

 insert into Projets(id ,titre,nombre_jour_real)values(1,'azerty',4)
select *from Projets;
 begin transaction;
 delete from Projets where id=1;
 rollback;
 select*from Projets;

 insert into Projets(id ,titre,nombre_jour_real)values(1,'azerty',4)
select *from Projets;
 begin transaction;
 delete from Projets where id=1;
 update Projets set nombre_jour_real=6 where id=1;
 save transaction er;