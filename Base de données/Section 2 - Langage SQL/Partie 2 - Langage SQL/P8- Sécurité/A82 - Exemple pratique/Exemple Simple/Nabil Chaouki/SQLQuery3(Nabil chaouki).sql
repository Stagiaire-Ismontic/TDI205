create login ali with password='halima' ,Default_database="Ecole"

grant update on etudiant  to ali with grant option;
deny  update on etudiant to ali  cascade;
grant update,select,delete,insert on etudiant to ali;
revoke update,select,delete,insert on etudiant to ali;
drop login ali;
