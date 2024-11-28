using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Windows.Forms;

namespace gestLivres
{
    internal static class Database
    {
        private static string connectionString = "server=localhost; database=bd_livres; uid=appLivre; pwd=Passsw0rd";

        internal static List<Categorie> GetCategorie()
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

        internal static List<Livre> GetLivres()
        {
            List<Livre> livres = new();
            int currentId = -1;
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand myCommand = new(@"select id_livre, livre.isbn, livre.titre, livre.description , categorie.nom_categorie nom_categorie, auteur.nom, auteur.prenom
                           from livre
                          inner join categorie on categorie.id_categorie = livre.id_categorie
                          inner join auteur on auteur.id_auteur = livre.id_auteur ;",
                    sqlConnection))
                {
                    using MySqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (currentId != (int)reader["id_livre"])
                        {
                            livres.Add(

                            new()
                            {
                                Id_livre = (int)reader["Id_livre"],
                                Isbn = (string)reader["isbn"],
                                Titre = (string)reader["titre"],
                                Description = (string)reader["Description"]
                            }
                            );
                        }

                        currentId = (int)reader["id_livre"];
                    }
                }
                sqlConnection.Close();
            }
            return livres;
        }

        internal static List<Auteur> GetAuteur()
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

        internal static void AjoutAuteur(Auteur auteur)
        {
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();

                using (MySqlCommand cmd = new("INSERT INTO Auteur (prenom, nom) VALUES (@prenom, @nom)", sqlConnection))
                {
                    cmd.Parameters.Add(new MySqlParameter("@prenom", auteur.Prenom));
                    cmd.Parameters.Add(new MySqlParameter("@nom", auteur.Nom));
                    cmd.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }

        internal static void ModifierAuteur(Auteur auteur)
        {
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();

                using (MySqlCommand cmd = new(@"UPDATE Auteur set
                                              prenom=@prenom,
                                              nom=@nom
                                              where Id_Auteur = @id", sqlConnection))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", auteur.Id_Auteur));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", auteur.Prenom));
                    cmd.Parameters.Add(new MySqlParameter("@nom", auteur.Nom));
                    cmd.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }

        internal static void SupprimerAuteur(Auteur auteur)
        {
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();

                using (MySqlCommand cmd = new("delete from auteur where auteur.id_auteur = @id1", sqlConnection))

                {
                    cmd.Parameters.Add(new MySqlParameter("@id1", auteur.Id_Auteur));

                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}