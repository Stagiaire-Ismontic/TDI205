declare @i int =0;
declare curseur cursor for select @i;
open curseur
if @i=0
begin
print 'A'
end
else
begin
print 'B'
end
close curseur;

