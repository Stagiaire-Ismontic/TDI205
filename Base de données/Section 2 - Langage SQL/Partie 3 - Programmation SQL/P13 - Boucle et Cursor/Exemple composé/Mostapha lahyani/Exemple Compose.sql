declare @M int =10;
declare curseur cursor for select @M;
open curseur
if @M=10
begin
print 'WELCOME'
end
else
begin
print 'TRY AGAIN'
end
close curseur;

