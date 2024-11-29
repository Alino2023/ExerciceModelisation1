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
    public partial class formAuteurs : Form
    {
        public formAuteurs()
        {
            InitializeComponent();
        }

        private void formAuteurs_Load(object sender, EventArgs e)
        {
            RefreshAuteurs();
            lstAuteurs.DisplayMember = "FullNameAuteur";
            lstAuteurs.ValueMember = "Id_auteur";
        }

        private void RefreshAuteurs()
        {
            lstAuteurs.Items.Clear();

            foreach (Auteur a in Database.GetAuteur())
            {
                lstAuteurs.Items.Add(a);
            }
        }

        private string ObtenirPrenomParFullNameAuteur(string FullNameAuteur)
        {
            return FullNameAuteur.Substring(0, FullNameAuteur.IndexOf(" "));
        }

        private string ObtenirNomParFullNameAuteur(string FullNameAuteur)
        {
            return FullNameAuteur.Substring(FullNameAuteur.IndexOf(" ") + 1);
        }

        private void btnAjouterAuteur_Click(object sender, EventArgs e)
        {
            Auteur auteur = new()
            {
                Prenom = ObtenirPrenomParFullNameAuteur(textBoxAuteur.Text),
                Nom = ObtenirNomParFullNameAuteur(textBoxAuteur.Text)
            };
            Database.AjoutAuteur(auteur);
            RefreshAuteurs();
            textBoxAuteur.Text = string.Empty;
        }

        private void btnModifierAuteur_Click(object sender, EventArgs e)
        {
            if (lstAuteurs.SelectedItems != null)
            {
                Auteur auteur = lstAuteurs.SelectedItem as Auteur;
                Auteur ModifierUnAuteur = new()
                {
                    Id_Auteur = auteur.Id_Auteur,
                    Prenom = ObtenirPrenomParFullNameAuteur(txtAuteur.Text),
                    Nom = ObtenirNomParFullNameAuteur(txtAuteur.Text)
                };
                Database.ModifierAuteur(ModifierUnAuteur);
                RefreshAuteurs();
                txtAuteur.Text = "";
            }
        }

        private void btnSupprimerAuteur_Click(object sender, EventArgs e)
        {
            if (lstAuteurs.SelectedItems != null)
            {
                Database.SupprimerAuteur(lstAuteurs.SelectedItem as Auteur);
            }
            RefreshAuteurs();
        }
    }
}