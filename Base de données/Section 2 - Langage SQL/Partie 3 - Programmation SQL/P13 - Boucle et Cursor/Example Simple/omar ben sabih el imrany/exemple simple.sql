insert into projets(titre varchar(15),n_jours int);
@i int = 0;
while(@i<=5)
begin
	values('titre'+@i,20);
	set @i=@i+1;
	end
