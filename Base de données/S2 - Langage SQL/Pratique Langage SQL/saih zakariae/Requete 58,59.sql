
/*requete 58*/
create view ListeStagiaires as select nom,id from Stagiaires;

/*requte 59*/

create index index_nom on Stagiaires(nom);