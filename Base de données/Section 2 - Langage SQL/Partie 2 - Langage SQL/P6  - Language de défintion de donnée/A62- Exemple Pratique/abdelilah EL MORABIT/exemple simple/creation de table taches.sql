create table taches(id int primary key,titre varchar(20),proje_id int,nombre_jours_realisation int,foreign key(id) references projets(id));
