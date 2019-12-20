Create database GestionFacture;
use GestionFacture
Create table Client (IdClient int primary key,Nom varchar(50));
Create table Facture (IdFacture int primary key,Titre varchar(50),Somme money,ClientId int ,constraint fk foreign key (ClientId) references Client(IdClient));
select * from Client ;
select * from Facture;
