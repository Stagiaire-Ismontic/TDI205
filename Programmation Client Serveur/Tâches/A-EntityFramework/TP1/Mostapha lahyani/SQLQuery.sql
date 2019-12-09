Create database GestionClient

Use GestionClient

Create table Client(IdClient int primary key,Cin varchar(50),Nom varchar(50),Prenom varchar(50));

Create table Commande(IdCommande int primary key,ClientId int FOREIGN KEY (ClientId) REFERENCES Client(IdClient));

