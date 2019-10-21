create table player(player_name varchar(30));

DECLARE @name VARCHAR(30);
set @name='';
print @name;
 
DECLARE select_player_cursor CURSOR FOR
	SELECT player_name FROM player ;
 
OPEN select_player_cursor;
 
FETCH select_player_cursor INTO @name;
 
WHILE @@FETCH_STATUS = 0
BEGIN
if @name!='cr7'
begin
	PRINT @name;
	FETCH select_player_cursor INTO @name;
	end
END
 
CLOSE select_player_cursor;
DEALLOCATE select_player_cursor;

