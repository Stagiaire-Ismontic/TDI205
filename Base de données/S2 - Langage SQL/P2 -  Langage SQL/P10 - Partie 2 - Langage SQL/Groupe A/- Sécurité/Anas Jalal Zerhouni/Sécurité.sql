create login  Apprenant with password='123456', default_database="Gestion";

grant update on Projets to  Apprenant;

revoke update on Projets from  Apprenant;

grant all privileges on Projets to  Apprenant; 

revoke all privileges on Projets from  Apprenant;

drop login  Apprenant;