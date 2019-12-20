drop database GestionFacture;
create database GestionFacture;
use GestionFacture
Create table Client (IdClient int primary key,Nom varchar(50));
Create table Facture (IdFacture int primary key identity(1,1),Titre varchar(50),Somme money,ClientId int ,constraint fk foreign key (ClientId) references Client(IdClient));
insert  into Client values (1,'Ilias zekri'),(2,'Mustapha lahyani')
select * from Client ;
select * from Facture;
