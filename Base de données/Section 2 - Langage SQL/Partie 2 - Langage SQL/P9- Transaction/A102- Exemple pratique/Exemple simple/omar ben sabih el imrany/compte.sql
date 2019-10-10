insert into compte(id_compte,nom,prenom) values(1,'mohamed','ali')
select * from compte;
begin transaction;
update compte set id_compte=2 where nom=mohamed;