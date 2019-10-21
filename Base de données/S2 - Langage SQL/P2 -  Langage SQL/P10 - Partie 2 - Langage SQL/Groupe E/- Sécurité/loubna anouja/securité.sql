create login loulou with password='123456',default_database=GestionProjet;

drop login loulou;

grant update on Projet to loulou with grant option;

deny update on Projet to loulou cascade;

grant update,insert,select,delete on Projet to loulou;

revoke update,select,insert,delete to loulou;