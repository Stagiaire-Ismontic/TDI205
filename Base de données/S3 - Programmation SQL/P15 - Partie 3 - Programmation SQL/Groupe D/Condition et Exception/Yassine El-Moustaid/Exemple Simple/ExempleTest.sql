create database ExempleTest;

create table Production(ProductNumber int , Category nvarchar(30),ProductLine nvarchar(30));


SELECT   ProductNumber, Category =  
      CASE ProductLine  
         WHEN 'R' THEN 'Road'  
         WHEN 'M' THEN 'Mountain'  
         WHEN 'T' THEN 'Touring'  
         WHEN 'S' THEN 'Other sale items'  
         ELSE 'Not for sale'  
      END
FROM Production  


Declare @n1 int=1;
Declare @n2 int=1;

if @n1=@n2 
	print @n1 
else 
	print @n2

