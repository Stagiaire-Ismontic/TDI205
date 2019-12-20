Create database GestionFacture;
use GestionFacture
Create table Client (IdClient int primary key,Nom varchar(50));
Create table Facture (IdFacture int primary key,Titre varchar(50),Somme money,ClientId int ,constraint fk foreign key (ClientId) references Client(IdClient));
select * from Client ;
select * from Facture;
insert into  Client values(1,'ilias') 
insert into Facture values (1,'Fact1',4000,1)