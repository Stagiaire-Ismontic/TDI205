
declare @catID int,
		@catName varchar;
		--@UnitPrice money;

declare catProduct cursor 
		for select [CategoryID],[CategoryName] from Categories

open catProduct

fetch next from catProduct into @catID,@catName

while (@@FETCH_STATUS = 0)
begin
	print 'cat ID:'+cast(@catID as varchar)+' categorie nome:'+@catName;
	print '--------------------------------------------';
	select [ProductName] from Products where CategoryID=@catID;
	fetch next from catProduct into @catID,@catName;
end

close catProduct;
deallocate catProduct;