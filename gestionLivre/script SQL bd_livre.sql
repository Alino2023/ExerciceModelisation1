/* voir les différentes bases de données */
show databases; 


/* Pour supprimer la base de données bd_livres */
drop database bd_livres;


/*Créer la base de données bd_livres*/
create database bd_livres;

/*Specifier la base de donnees à utiliser pour les requetes ci-après*/
use bd_livres;

/*Voir les tables de la base de donnees specifiée*/
show tables;


/*creation de la table categorie*/
create table categorie (
id_categorie int not null auto_increment,
nom_categorie nvarchar(255) not null,
primary key (id_categorie)
);

/*creation de la table auteur*/
create table auteur(
id_auteur int not null auto_increment,
nom nvarchar(80),
prenom nvarchar(255),
primary key (id_auteur)
);



/*creation de la table livre*/
create table livre (
id_livre int not null auto_increment,
isbn varchar(17) not null unique, 
titre nvarchar(255) not null, 
description nvarchar(255) not null,
id_categorie int not null,
id_auteur int not null,
foreign key (id_auteur) references auteur (id_auteur),
foreign key (id_categorie) references categorie (id_categorie),
primary key (id_livre)
);


/*####### INSERTION DE QUELQUES DONNES DE TEST #####*/

/*insertion de donnees dans la table categorie*/
insert into categorie (nom_categorie)
values ('roman polar'),
('Biographie'), ('recueil de voyage'), 
('roman policier'), ('autobiographie');


/*insertion de donnees dans la table auteur*/
insert into auteur (nom, prenom) 
values ('Ouellette', 'Francis'),
 	   ('Maupassant', 'Guy'),
       ('Zerbo', 'Ki'),
       ('Badian', 'Seydou'),
       ('Alemdjrodo', 'Alexandre'),
       ('Hugo', 'Victor');

/*insertion de donnees dans la table livre*/
 insert into livre (isbn, titre, description, id_categorie, id_auteur)  
 values ('978-3-16-148410-0', 'Melasse de fantaisie','Litterature québécoise','1','2'),
 ('978-0-306-40615-7', "Sous l'orage",'Littérature africaine noire','2','1'),
 ('1-56619-909-3', 'Les fleurs du mal','Poésie','5','3'),
 ('978-1-56619-909-4', "Le réveil d'un continent","Roman d'histoire",'4','4'),
 ('0-201-53082-1', 'Les dérives de la science','Roman philosophique','3','3');
 
 
    
/*Afficher les livres, leur catégories et les auteurs*/
select livre.id_livre,  livre.isbn, livre.titre, livre.description, categorie.nom_categorie catégorie, auteur.nom auteur 
from livre 	
inner join categorie  on livre.id_categorie = categorie.id_categorie
inner join auteur on livre.id_auteur = auteur.id_auteur;



/*creation d'user pour l'application qui va utiliser notre base de données'*/
create user 'appBiblio@localhost'  identified by 'Passsw0rd';

/*Attribuer les droits requis*/
grant select, insert, update, delete on bd_livres.* to 'appBiblio@localhost';

/*Voir les droits accordés à l'utilisateur 'appBiblio@localhost'*/
show grants for 'appBiblio@localhost' ;




/*creation de la chaine de connexion dans la connexion dans c#*/
 /*private static string connectionString = "server=localhost; database=bd_livres;uid=appBiblio; pwd=Passsw0rd";*/
 
 