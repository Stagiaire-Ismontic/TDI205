CREATE database biblio_Entity_frameWork
create table Livre(id int primary key,titre varchar(50),categorie varchar(50))
create table editeur(id int primary key,nom varchar(50),prenom varchar(50),numero_inscription int ,id_livre int foreign key references Livre(id))

select * from editeur
select * from Livre
insert into Livre values(1,'l1','l1'),(2,'l2','l2'),(3,'l3','l3');
insert into editeur values(1,'lki','jj',5,1)

truncate table Livre
truncate table editeur