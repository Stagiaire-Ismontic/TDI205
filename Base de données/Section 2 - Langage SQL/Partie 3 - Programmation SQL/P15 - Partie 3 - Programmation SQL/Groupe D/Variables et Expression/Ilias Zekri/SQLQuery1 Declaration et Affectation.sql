
Create Database Test;
Create Table Exe (test1 float,test2 float);
Insert Into Exe Values(12,10);
Declare @Somme float;
Set @Somme=(Select Sum(test1)+Sum(test2) from Exe);
Print @Somme;
Print GetDate();