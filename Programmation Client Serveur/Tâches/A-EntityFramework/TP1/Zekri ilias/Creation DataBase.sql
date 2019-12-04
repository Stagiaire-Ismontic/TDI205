Create database School;
Use School
create table Groupe(IdGroupe int primary key,NomG varchar(50));
create table Student(IdStudent int primary key, NomS varchar(50),GroupeId int FOREIGN KEY (GroupeId) REFERENCES Groupe(IdGroupe));
