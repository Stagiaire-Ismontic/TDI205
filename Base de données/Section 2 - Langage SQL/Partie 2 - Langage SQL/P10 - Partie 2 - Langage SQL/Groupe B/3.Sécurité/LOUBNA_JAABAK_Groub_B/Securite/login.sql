create login loubnna with password='loubna', Default_database="jointure";
drop login loubnna; /*supprimer immediatement*/
grant update on Projets to loubnna with grant option
deny update Tache to loubnna; /*enlever le droit pour update*/

grant update select,delete,insert on Tache to loubnna;/*donner le droit d'utiliser les requetes */
revoke update select,delete,insert on Tache to loubnna; /*deny le droit*/
