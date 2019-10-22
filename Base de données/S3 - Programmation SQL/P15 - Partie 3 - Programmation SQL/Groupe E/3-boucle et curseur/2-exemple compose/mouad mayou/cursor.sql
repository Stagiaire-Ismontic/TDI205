create table stagiaire(nomS varchar(20));
insert into stagiaire values('youssra');
declare @nom varchar(50);
set @nom='';
print @nom;

declare stagiaire_cursor cursor for 
 select nomS from stagiaire;
 open stagiaire_cursor ;

 fetch  stagiaire_cursor into @nom;
 while  @@FETCH_STATUS =0
 begin 
 if @nom!='youssra'
 begin 
   print @nom;
   fetch stagiaire_cursor into @nom;
   end 
  end close stagiaire_cursor ;
  deallocate stagiaire_cursor ;  