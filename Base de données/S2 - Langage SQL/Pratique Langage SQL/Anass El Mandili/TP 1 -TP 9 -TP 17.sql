--TP 1
create database gestionprojets;

create table stagiaire(id int primary key,nom varchar(20),prenom varchar(20),cin varchar(20),ville varchar(20),date_naissance date,e_mail varchar(20),tel_fixe int,tel_portable int);

create table projets(id int primary key,titre varchar(30),nombre_jours_realisation int);

create table taches(id int primary key,titre varchar(30),projet_id int ,nombre_jours_realisation int ,foreign key (projet_id) references projets(id));

create table tachesStagiaiers(satgiaier_id int,tache_id int,primary key(satgiaier_id,tache_id),date_debut date,date_fin date ,foreign key(satgiaier_id) references stagiaire(id),foreign key(tache_id) references taches(id));

--TP 9
declare  @Nombre_Jour int ;
select @Nombre_Jour = DATEDIFF(day, date_debut,date_fin)from tachesStagiaiers  ;
print @Nombre_Jour;
declare @nom_et_prenom nvarchar(25);
select @nom_et_prenom = nom +' '+prenom from stagiaire where prenom = 'ali';
print @nom_et_prenom;

--TP17
--ex1
declare cur1 cursor for select titre,id from Projets
declare @t1 varchar(50)
declare @id int 
open cur1
fetch cur1 into @t1,@id
while(@@FETCH_STATUS=0)
begin 
update Taches set titre=titre+@t1 where projet_id=@id
fetch cur1 into @t1,@id
end
close cur1
deallocate cur1
select * from Taches
select * from projets
--ex2
declare @id_projets int
declare cursor1 cursor for select p.id from projets p
open cursor1
fetch cursor1 into @id_projets
while @@FETCH_STATUS=0
begin
declare @Sum int
select @Sum=sum(t.nombre_jours_realisation) from taches t inner join projets p on t.projet_id=p.id where p.id=@id_projets
update projets set nombre_jours_realisation=@Sum where @id_projets=@id_projets
fetch cursor1 into @id_projets
end
close cursor1
deallocate cursor1
select * from taches








