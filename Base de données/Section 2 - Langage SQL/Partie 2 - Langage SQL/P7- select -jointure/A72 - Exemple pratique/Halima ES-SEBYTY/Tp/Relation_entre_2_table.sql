alter table Tache
add constraint Tache_Projet FOREIGN KEY (Id) 
references Projet (Id)
on update cascade
on delete cascade