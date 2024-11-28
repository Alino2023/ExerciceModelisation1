using Google.Protobuf.Compiler;
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
    public partial class formLivres : Form
    {
        public formLivres()
        {
            InitializeComponent();
        }

        private void formLivres_Load(object sender, EventArgs e)
        {
            cbAuteur.DataSource = Database.GetAuteur();
            cbAuteur.DisplayMember = "FullNameAuteur";
            cbAuteur.ValueMember = "Id_Auteur";
            cbAuteur.SelectedIndex = -1;

            cbCategorie.DataSource = Database.GetCategorie();
            cbCategorie.DisplayMember = "Nom_Categorie";
            cbCategorie.ValueMember = "Id_Categorie";
            cbCategorie.SelectedIndex = -1;

            lstLivres.DisplayMember = "Titre";
            lstLivres.ValueMember = "Id_livre";

            RefreshLivres();
        }

        private void RefreshLivres()
        {
            lstLivres.Items.Clear();

            foreach (Livre p in Database.GetLivres())
            {
                lstLivres.Items.Add(p);
            }
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            Livre livre = new()
            {
                Titre = txtTitre.Text,
                Isbn = txtIsbn.Text,
                Description = txtDescription.Text,
            };

            Database.AjoutLivre(livre);
            RefreshLivres();
        }
    }
}