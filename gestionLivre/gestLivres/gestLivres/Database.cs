using MySql.Data.MySqlClient;

namespace gestLivres
{
    internal static class Database
    {
        private static string connectionString = "server=localhost; database=bd_livres; uid=appBiblio; pwd=Passsw0rd";

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

        internal static List<Livre> GetLivres()
        {
            List<Livre> livres = new();
            int currentId = -1;
            using (MySqlConnection sqlConnection = new(connectionString))
            {
                sqlConnection.Open();
                using (MySqlCommand myCommand = new(@"select livre.isbn, livre.titre, livre.description , categorie.nom_categorie nom_categorie, auteur.nom, auteur.prenom
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
                    //if (reader["id_categorie"].GetType() != typeof(DBNull))
                    //{
                    //    Id_categorie = (int)reader["id_categorie"]

                    //});
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