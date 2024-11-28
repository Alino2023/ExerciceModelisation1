namespace gestLivres
{
    internal class Auteur
    {
        public int Id_Auteur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string FullNameAuteur
        { get { return Prenom + " " + Nom; } }
    }
}