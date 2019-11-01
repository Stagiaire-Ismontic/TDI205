/* Tp 1 */
Create Database GestionProjets;

create table projets(id int not null primary key, titre varchar(20),nombre_jours_realisation varchar(20));

create table Stagiaires(id int not null primary key,nom varchar(20),prenom varchar(20),cin varchar(20),email varchar(40),date_naissance date,tel_fix varchar(20),tel_portable varchar(20));

create table taches(id int not null primary key,titre varchar(20),projet_id int not null,nombre_jours_realisation varchar(20),foreign key(id) references projets(id));

create table TachesStagiaires(stagiaire_id int,tache_id int, primary key(stagiaire_id,tache_id),date_debut date,date_fin date);
alter table taches add  nombre_jours_realisation int
alter table taches drop column  nombre_jours_realisation
/* Tp 9 */
insert into Stagiaires values(1,'gr','ali','K112233','aaaa@gmail.com','11-11-2011','0161122334','055144233');
insert into Stagiaires values(2,'kesh','said','K445566','bbbb@gmail.com','01-01-2001','0123456789','059988776');

insert into projets values(1,'Prjts','5');

insert into taches values(1,'tchs',2,'3');

insert into TachesStagiaires values(1,1,'01-01-2019','02-02-2019');


declare @nbr_jour int
select @nbr_jour =DATEDIFF(day,date_debut,date_fin) from TachesStagiaires;
print @nbr_jour

declare @nom_et_prenom nvarchar(150)
select @nom_et_prenom = nom+' '+prenom from Stagiaires where nom ='gr'
print @nom_et_prenom

/* Tp 17 */
/*methode 1*/
declare cur1 cursor for select titre,id from Projets
declare @t1 varchar(50)
declare @id int 
open cur1
fetch cur1 into @t1,@id
while(@@FETCH_STATUS=0)
begin 
update Taches set titre=titre+@t1 where projet_id=@id
print @id
print @t1
fetch cur1 into @t1,@id
end
close cur1
deallocate cur1
select * from Taches
/*methode 2*/
declare cursname cursor for select t.id,p.titre,t.titre from projets p inner join taches t on t.projet_id=p.id
declare @titreP varchar(30)='';
declare @titreT varchar(30)='';
declare @id_taches int;
open cursname
fetch next from cursname into @id.taches,@titreP,@titreT;
while @@FETCH_STATUS=0
begin
update taches set titre=@titreP+@titreT where id=@id_taches
fetch next from cursname into @id_taches,@titreP,@titreT
end
close cursname
deallocate cursname

/*ex2 tp17*/
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
