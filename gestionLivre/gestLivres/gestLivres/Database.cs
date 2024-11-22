using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestLivres
{
    internal static class Database
    {
        private static string connectionString = "server=localhost; database=db_livres;uid=appUser: pwd=P@sssw0rd";

        private static List<Categorie> GetCategorie()
        {
            List<Categorie> categories = new();
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand myCommand = new("select id_categorie, nom_categorie from categorie", sqlConnection))
                {
                    using MySqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //personnes.Add(((string)reader["prenom"]) + " " + ((string)reader["nom"]));
                        //categories.Add($"{(string)reader["isbn"]}{(string)reader["titre"]} {(string)reader["description"]}");
                        categories.Add(
                            new()
                            {
                                Id_Categorie = (int)reader["id_categorie"],
                                Nom_Categorie = (string)reader["nom_categorie"]
                            }
                            );
                    }
                }
                sqlConnection.Close();
            }
            return categories;
        }

        private static List<Livre> GetLivres()
        {
            List<Livre> livres = new();
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand myCommand = new("select isbn, titre, description from livre", sqlConnection))
                {
                    using MySqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //personnes.Add(((string)reader["prenom"]) + " " + ((string)reader["nom"]));
                        //livres.Add($"{(string)reader["isbn"]}{(string)reader["titre"]} {(string)reader["description"]}");
                        livres.Add(
                            new()
                            {
                                Isbn = (string)reader["isbn"],
                                Titre = (string)reader["titre"],
                                Description = (string)reader["description"]
                            }
                            );
                    }
                }
                sqlConnection.Close();
            }
            return livres;
        }

        private static List<Auteur> GetAuteur()
        {
            List<Auteur> auteurs = new();
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand myCommand = new("select id_auteur, nom, prenom from auteur", sqlConnection))
                {
                    using MySqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        auteurs.Add(
                            new()
                            {
                                Id_Auteur = (int)reader["id_auteur"],
                                Nom = (string)reader["nom"],
                                Prenom = (string)reader["prenom"]
                            }
                            );
                    }
                }
                sqlConnection.Close();
            }
            return auteurs;
        }
    }
}