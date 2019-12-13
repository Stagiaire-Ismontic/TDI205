Create database GestionCom;
use GestionCom
Create table Produit (IdProduit int primary key,Nom varchar(50),Prix money);
Create table Commande (IdCommande int primary key,Descriptions varchar(50),Prix money,ProduitId int ,constraint fk foreign key (ProduitId) references Produit(IdProduit));
