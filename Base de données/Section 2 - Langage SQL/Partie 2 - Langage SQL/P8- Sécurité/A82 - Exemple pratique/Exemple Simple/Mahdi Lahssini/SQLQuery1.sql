create database Master1;
use Master1
create login mahdi with password ='azerty123' ,
Default_database="Master1";

drop login mahdi;

create table test1 (nom varchar(50),prenom varchar(50),age int)

Grant update on test1 to mahdi with grant option;

deny update on test1 to mahdi;

revoke update on test1 from mahdi;