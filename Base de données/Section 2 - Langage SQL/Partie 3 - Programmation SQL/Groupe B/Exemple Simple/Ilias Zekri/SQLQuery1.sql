declare @nom varchar(30)='ilias';
declare @nom2 varchar(30)='zekri';
if @nom2=@nom 
	select @nom;
else
	select @nom2;
