create table auteur(auteur_nom  varchar(20))
declare @nom varchar(20);
set @nom='';
print @nom;
declare azerty
cursor for
select auteur_nom from auteur;
open azerty;
fetch azerty into @nom;
while @@fetch_status=0
begin 
if @nom!='omar'
begin 
print @nom;
fetch azerty;
into @nom;
end 
end
close azerty;
Deallocate azerty;

