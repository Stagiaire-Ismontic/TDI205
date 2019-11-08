create database Gestionsprojet;
create table stagiaires(id int,nom varchar(30),prenom varchar(30),cin varchar(30),ville varchar(30),date_naissance date,email varchar(30),teleFix varchar(30),teleportable varchar(30));
create table projet(id_projet int,titre varchar(30),nombre_jour_realisation int);
create table taches(id_tache int,titre_tache varchar(30),id_projet int,nombre_jour_realisation_tache int);
create table tachesStagiaires(id int ,id_tache int,date_debut date,date_fin date);
insert into stagiaires values (1,'nom1','prenom1','cin1','ville1','14/01/1999','email1','0111111','111111'),(2,'nom2','prenom2','cin2','ville2','15/01/1999','email2','022222','22222222');
insert into projet(id_projet,titre) values(1,'projet1'),(2,'projet2');
insert into taches(id_tache,titre_tache,id_projet) values (1,'tache1',1),(2,'tache1',2);
insert into tachesStagiaires values (1,1,'14/01/1999','14/01/2005'),(2,2,'02/02/2008','02/02/2019');
