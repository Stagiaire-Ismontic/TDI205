create function ProjetStagiaire(@id int)
returns table
as
return(select p.id_projet,p.titre from projet p inner join taches t on p.id_projet=t.id_projet inner join tachesStagiaires ts on id=ts.id );
