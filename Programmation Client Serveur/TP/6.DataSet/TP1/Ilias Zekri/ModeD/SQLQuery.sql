Create database Gestionnaire;

 use Gestionnaire

 Create Table Produit(ProduitId int primary key,Nom varchar(50),Prix money);

 insert into Produit values(1,'Produit 1',400),(2,'Produit 2',200),(3,'Produit 3',300);

 Select * from Produit;
