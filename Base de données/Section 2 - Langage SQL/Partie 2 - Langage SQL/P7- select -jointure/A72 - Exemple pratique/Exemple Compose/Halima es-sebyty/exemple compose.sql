Create table Orders( 
OrderID varchar(30) primary key not null,
CustomerID varchar(30) not null,
EmployeeID varchar(30) not null)

insert into Orders values(1,1,1),(2,2,2);

Create table Customers(
CustomerID varchar(30) primary key not null,
CustomerName varchar(30) not null,
ContactName varchar(69) not null,
Addreess varchar(69) not null,
City varchar(30) not null,
PostalCode int not null,
Country varchar(30) not null)

insert into Customers values(1,'Maria',0046,'swedensweden','stockholm',9999,'sweden'),(2,'lydia',0049,'unknown','unknown2',8888,'germany');


SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;