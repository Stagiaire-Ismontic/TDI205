create login imane with password='123456',default_database=GestionProjet;

drop login imane;

grant update on Prjt to imane with grant option;

deny update on Prjt to imane cascade;

grant update,insert,select,delete on Prjt to imane;

revoke update,select,insert,delete to imane;