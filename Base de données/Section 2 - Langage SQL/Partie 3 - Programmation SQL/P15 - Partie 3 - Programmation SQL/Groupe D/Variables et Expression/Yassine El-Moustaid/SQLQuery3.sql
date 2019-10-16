Create Database mydata;
Create Table tab (tb1 float,tb2 float);
Insert Into tab Values(15,5);
Declare @total float;
Set @total=(Select Sum(tb1)+Sum(tb2) from tab);
Print @total;
Print GetDate();