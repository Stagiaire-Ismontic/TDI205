Create table Mention 
(
  id int Identity( 1,1 ),
  nom varchar(50),
  nmax float,
  nmin float
);

insert into Mention values('mohamed',15,10);
insert into Mention values('yassine',13,8);
insert into Mention values('toto',17,5);
select * from Mention;