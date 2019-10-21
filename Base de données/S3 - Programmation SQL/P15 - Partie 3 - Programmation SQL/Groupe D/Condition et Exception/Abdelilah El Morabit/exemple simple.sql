create table tab(Pnum int,ListPrice float,PriceRange nvarchar(50));

SELECT   Pnum,PriceRange=   
      CASE   
         WHEN ListPrice =  0 THEN 'Mfg item - not for resale'  
         WHEN ListPrice < 50 THEN 'Under $50'  
         WHEN ListPrice >= 50 and ListPrice < 250 THEN 'Under $250'  
         WHEN ListPrice >= 250 and ListPrice < 1000 THEN 'Under $1000'  
         ELSE 'Over $1000'  
      END  
FROM tab

declare @var float=(select sum(ListPrice) from tab);
if @var>250 begin 
delete from tab where ListPrice<250;
end
else
print 'the price is cheap';