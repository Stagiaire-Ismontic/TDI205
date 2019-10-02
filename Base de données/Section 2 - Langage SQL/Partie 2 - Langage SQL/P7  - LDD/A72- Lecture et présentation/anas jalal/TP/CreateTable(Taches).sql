Create Table Taches(
	id int not null primary key,
	titre varchar(30),
	Projet_id int foreign key references Projets(id)
);