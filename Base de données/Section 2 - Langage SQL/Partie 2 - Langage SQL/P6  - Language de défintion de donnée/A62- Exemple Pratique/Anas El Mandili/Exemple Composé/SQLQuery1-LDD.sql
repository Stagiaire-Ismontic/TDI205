create database Gestion_Project;

CREATE TABLE Project(
    Id_Project int primary key,
    Titre varchar(20) NOT NULL,   
);
CREATE TABLE Stagiaire(
    Id_Stagiaire int NOT NULL,
    Titre varchar(20) NOT NULL,
    Id_Project int FOREIGN KEY  REFERENCES Project(Id_Project)
); 
alter table Project add matriele varchar(25) ;
select *from Project;
alter table Project drop column Titre;
drop table Stagiaire;
drop database Gestion_Project;


