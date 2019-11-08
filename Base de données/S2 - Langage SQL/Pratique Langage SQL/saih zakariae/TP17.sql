Declare @i int
declare mod 
cursor for
 select  id from Taches
open mod
fetch mod into @i
while(@@FETCH_STATUS=0)
begin
  declare  @T varchar(50)= (select P.titre from Projets P inner join Taches T on P.id=T.projet_id where T.id=@i)+''+(select T.titre from Projets P inner join Taches T on P.id=T.projet_id where T.id=@i);
  update Taches Set Titre =@T where id=@i;
  fetch mod into @i
End
close mod
deallocate mod
Select * from Taches;