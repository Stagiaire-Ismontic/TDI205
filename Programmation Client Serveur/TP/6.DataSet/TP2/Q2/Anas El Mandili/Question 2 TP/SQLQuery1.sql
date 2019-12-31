create database DatabaseTP
create table Etablissement1(
	Etabliss_Id int primary key not null,
	Etabliss_Name varchar(40),
	Etabliss_Desc varchar(50)
	);
create table Etudiant1(
	Etudiant_Id int primary key not null,
	Etudiant_Name varchar(40),
	Etudiant_Phone varchar(45),
	Etabliss_Id int foreign key references Etablissement1(Etabliss_Id)
	);
insert into Etablissement1 values(1,'AJAX','Equipe de Foot')
insert into Etablissement1 values(2,'ENCJ','Ecole de Commerce')
insert into Etudiant1 values(1,'Ali','0678564534',1)
insert into Etudiant1 values(2,'Samira','0678667434',2)
insert into Etudiant1 values(3,'Madani','0678564534',2)