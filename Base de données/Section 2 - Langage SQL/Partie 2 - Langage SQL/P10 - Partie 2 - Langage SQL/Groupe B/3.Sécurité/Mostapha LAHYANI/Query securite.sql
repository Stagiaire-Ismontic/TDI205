create login Mostapha with password ='Mostapha',default_database ="Gestion_securite";

drop login Mostapha;

grant update on prj to Mostapha with grant option;

deny update on prj to Mostapha; /*enlever le droit pour update */

revoke update, select, delete, insert on tch to Mostapha; 

grant update select, delete, insert on tch to Mostapha; /*donner le droit d'utiliser les requetes*/

