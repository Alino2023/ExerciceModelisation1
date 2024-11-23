using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestLivres
{
    public partial class formLivre : Form
    {
        public formLivre()
        {
            InitializeComponent();
            lstLivres.DisplayMember = "Titre";

            lstLivres.ValueMember = "Isbn";
        }

        //private void Rafraichir()
        //{
        //    lstLivres.Items.Clear();

        //    foreach (Livre livre in Database.GetLivres())
        //    {
        //        lstLivres.Items.Add(livre);
        //    }
        //}

        private void Rafraichir()
        {
            // Vérifie si la liste des livres n'est pas nulle avant de la vider
            if (lstLivres != null)
            {
                lstLivres.Items.Clear();

                // Récupération des livres depuis la base de données
                var livres = Database.GetLivres();

                if (livres != null)
                {
                    foreach (Livre livre in livres)
                    {
                        lstLivres.Items.Add(livre);
                    }
                }
                else
                {
                    // Log ou message en cas de données nulles
                    MessageBox.Show("Aucun livre trouvé dans la base de données.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Gestion si lstLivres n'est pas initialisée
                throw new InvalidOperationException("La liste des livres (lstLivres) n'est pas initialisée.");
            }
        }

        private void tabCategories_Click(object sender, EventArgs e)
        {
        }

        private void tabLivres_Click(object sender, EventArgs e)
        {
            lstLivres.Items.Clear();
            lstLivres.Items.Add(((Livre)lstLivres.Items[lstLivres.SelectedIndex]).Livres);
            Rafraichir();
        }
    }
}