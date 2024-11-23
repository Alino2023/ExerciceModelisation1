using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestLivres
{
    internal class Livre
    {
        public int Id_livre { get; set; }
        public string Isbn { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }

        public List<Livre> Livres { get; set; } = new();
    }
}