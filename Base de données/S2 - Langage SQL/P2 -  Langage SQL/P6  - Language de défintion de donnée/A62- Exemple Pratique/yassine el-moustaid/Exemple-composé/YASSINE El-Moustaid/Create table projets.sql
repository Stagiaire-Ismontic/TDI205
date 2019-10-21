create table projets(id int not null primary key, titre varchar(20),nombre_jours_realisation varchar(20));

alter table projets add date_creation date;

alter table projets add date_modification date;

alter table projets add CONSTRAINT Check_date_et_titre CHECK ((titre='projet 1' or titre='projet 2') AND (date_creation<date_modification));
