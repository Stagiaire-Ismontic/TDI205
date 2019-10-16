Create Database MyDb;
Create Table MyTab (col1 float,col2 float);
Insert Into MyTab Values(89,69);
Declare @MySom float;
Set @MySom=(Select Sum(col1)+Sum(col2) from MyTab);
Print @MySom;
Print GetDate();