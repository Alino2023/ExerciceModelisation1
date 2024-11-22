/* voir les différentes BD */
show databases; 

/*Créer la bd emple*/
create database db_livres;

/*Specifier la base de donnees à utiliser pour les requetes ci-après*/
use db_livres;

/*Voir les tables de la base de donnees specifiée*/
show tables;

/*Afficher les colonnes de la table livre*/
show columns from livre;
desc livre;


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
isbn varchar(17) not null, 
titre nvarchar(255) not null, 
description nvarchar(255) not null,
id_categorie int not null,
id_auteur int not null,
foreign key (id_auteur) references auteur (id_auteur),
foreign key (id_categorie) references categorie (id_categorie),
primary key (isbn)
);




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
select livre.isbn, livre.titre, livre.description, categorie.nom_categorie catégorie, auteur.nom auteur 
from livre 	
inner join categorie  on livre.id_categorie = categorie.id_categorie
inner join auteur on livre.id_auteur = auteur.id_auteur;


/*creation d'user pour l'application qui va utiliser notre base de données'*/
create user 'appUser'@'localhost'  identified by 'P@sssw0rd';

/*Attribuer les droits requis*/
grant select, insert, update, delete on exemple.* to 'appUser'@'localhost';

/*creation de la chaine de connexion */
 /*private static string connectionString = "server=localhost; database=db_livre;uid=appUser: pwd=P@sssw0rd";*/
 
 