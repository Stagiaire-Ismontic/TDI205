create table  Stagiaires ( id int primary key,nom nvarchar(50), prenom nvarchar(20),cin nvarchar(50),
ville nvarchar(50),date_naissance date,e_mail nvarchar(50),tel_fixe int,tel_portable int);
drop table Stagiaires;
create table Projets (id int primary key, titre nvarchar(50), nombre_jours_realisation int) 
drop table Projets;

create table Taches (id int primary key, titre nvarchar(50),projet_id int constraint pt_id  foreign key(id) references Projets(id) , nombre_jours_realisation int) 
create table TachesStagiaires (stagiaire_id int,tache_id int constraint st_id foreign key(tache_id)references Taches(id),date_debut date,date_fin date)


insert into Projets values(1,'koko',223)
insert into Projets values(2,'soso',36)
insert into Taches values(1,'mada',1,23)


insert into Taches values(2,'nada',2,200)



insert into Stagiaires values(1,'Madani','Ali','K380001','Tanger','05-06-1995','madani.ali@gmail.com',0539000001,0600000001);
insert into Stagiaires values(2,'Madani','Moad','K380002','Tanger','03-02-1997','madani.moad@gmail.com', 0539000002,0600000002);
select *from Stagiaires;
truncate table TachesStagiaires;
insert into TachesStagiaires(stagiaire_id,date_debut,date_fin) values(3,'02-08-2018','05-12-2030');
insert into TachesStagiaires (stagiaire_id,date_debut,date_fin) values(4,'02-12-2018','02-02-2020');
select *from TachesStagiaires;
create function NombreTaches (@projet_id int)
returns int as
begin
 declare @nomre_Tache int
select @nombre_Tache = count(*) from Taches where projet_id =@projet_id ;


 return @nombre_Tache
 end

 select id,titre  as 'Nombre des Taches' from Projets