create function dbo.getTable(@fName varchar(50), @lName varchar(50), @Age int)
returns @myTable table(firstName varchar(50), LastName varchar(50), Age int)
begin
insert into @myTable values (@fName,@lName,@Age)

return 
end
select * from dbo.getTable('Zaid','kalini',22)
