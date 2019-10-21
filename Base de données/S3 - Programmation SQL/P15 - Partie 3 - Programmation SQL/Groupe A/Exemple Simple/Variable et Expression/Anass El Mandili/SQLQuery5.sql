<!-- declaration des variable-->
declare @a int, @b int , @Sum int;
set @Sum = 18+18;
print @Sum;
<!--La data Actuel-->
print getdate();
<!--Creation table avec l'insertion des données-->
create table Product(id int not null,qte int not null , prix int not null);
insert into Product values(1,20,2000);
insert into Product values(2,40,1500);
<!--Clacul de la somme des deux colonne-->
declare @jack int;
set @jack = (select sum(id)+sum(prix) from Product);
print @jack;
