create table Employé(
	num int,
	nom varchar(30),
	ville varchar(30),
	salaire varchar(20)
);

select * from Employé;

insert into Employé(num,nom,ville,salaire) values (1,'zaka','tanger',1000);
insert into Employé(num,nom,ville,salaire) values (2,'mouad','rifi',5000);
insert into Employé(num,nom,ville,salaire) values (3,'Abdelilah','meknas',6000);
insert into Employé(num,nom,ville,salaire) values (4,'hayat','azilal',4000);
insert into Employé(num,nom,ville,salaire) values (5,'amine','bni melal',1500);

/*requete 52*/
select *from Employé where salaire=(select max(salaire)from Employé);

/*requete 53*/

select * from Employé where salaire in(select max(salaire) as SalaireMax from Employé group by ville);
/*requete 54*/

select *from Employé where salaire > Any(select max(salaire) from Employé group by ville);
/*requete 55*/

select * from Employé where salaire < All(select max(salaire) from Employé);