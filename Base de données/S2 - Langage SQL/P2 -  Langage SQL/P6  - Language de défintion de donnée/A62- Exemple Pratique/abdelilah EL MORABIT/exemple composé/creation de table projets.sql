create table projets(id int primary key,titre varchar(20),nombre_jours_realisation int);

alter table projets add date_creation date;

alter table projets add date_modification date;

alter table projets add CONSTRAINT CHECK_TITRE_ET_DATE CHECK ((titre='projet 1' or titre='projet 2') AND (date_creation<date_modification));
