Declare @Id_projets int;
declare cursor1 cursor for select p.id from Projets p
open cursor1
Fetch cursor1 into @Id_Projets 
while @@FETCH_STATUS=0
begin
declare @sum int
select @sum=sum(T.nombre_jours_realisation) from Taches T
 inner join Projets p on T.projet_id =p.id where p.id=@Id_projets;
 update Projets set nombre_jours_realisation=@sum
 where id=@Id_projets
 fetch cursor1 into @Id_projets
 end 
 close cursor1
 deallocate cursor1
