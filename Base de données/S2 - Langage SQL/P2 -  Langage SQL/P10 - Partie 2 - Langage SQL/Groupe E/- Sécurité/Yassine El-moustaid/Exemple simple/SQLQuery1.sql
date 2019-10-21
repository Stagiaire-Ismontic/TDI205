create login azerty with password='123456',default_database=GestionProjet;

drop login azerty;

grant update on Projet to azerty with grant option;

deny update on Projet to azerty cascade;

grant update,insert,select,delete on Projet to azerty;

revoke update,select,insert,delete to azerty;