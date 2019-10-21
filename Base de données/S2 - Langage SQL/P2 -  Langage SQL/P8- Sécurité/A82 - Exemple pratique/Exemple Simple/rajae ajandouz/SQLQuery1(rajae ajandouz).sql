create login rajae with password='12345',default_database=Geston_projet

create login rachid with password='azerty',default_database=Geston_projet

drop login rachid

grant update on Projets to rajae with grant option

Deny Update on Projets to rajae

revoke update,select,delete,insert on Projets to rajae;
drop login rajae;

