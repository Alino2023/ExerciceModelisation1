using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace gestLivres
{
    public partial class formModitSupprCategorie : Form
    {
        public formModitSupprCategorie()
        {
            InitializeComponent();
        }

        private void RefreshLivres()
        {
            lstCategories.Items.Clear();

            foreach (Livre p in Database.GetLivres())
            {
                lstCategories.Items.Add(p);
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

        //private void btnModifierLivre_Click(object sender, EventArgs e)
        //{
        //    if (lstAuteurs.SelectedItems != null)
        //    {
        //        Auteur auteur = lstAuteurs.SelectedItem as Auteur;
        //        Auteur ModifierUnAuteur = new()
        //        {
        //            Id_Auteur = auteur.Id_Auteur,
        //            Prenom = ObtenirPrenomParFullNameAuteur(txtAuteurModifSup.Text),
        //            Nom = ObtenirNomParFullNameAuteur(txtAuteurModifSup.Text)
        //        };
        //        Database.ModifierAuteur(ModifierUnAuteur);
        //        RefreshAuteurs();
        //    }
        //}

        private void RefreshAuteurs()
        {
            lstCategories.Items.Clear();

            foreach (Auteur a in Database.GetAuteur())
            {
                lstCategories.Items.Add(a);
            }
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Categorie categorie = (Categorie)lstCategories.SelectedItem;
                Categorie ModifierUneCategorie = new()
                {
                    Id_Categorie = categorie.Id_Categorie,
                    Nom_Categorie = txtAuteurModifSup.Text
                };
                Database.ModifierCategorie(ModifierUneCategorie);
                RefreshCategorie();
            }
        }

        private void RefreshCategorie()
        {
            lstCategories.Items.Clear();

            foreach (Categorie c in Database.GetCategorie())
            {
                lstCategories.Items.Add(c);
            }
        }

        private void btnSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Database.SupprimerCategorie(lstCategories.SelectedItem as Categorie);
            }
            RefreshCategorie();
        }

        private void btnMofierAuteur_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Categorie categorie = (Categorie)lstCategories.SelectedItem;
                Categorie ModifierUneCategorie = new()
                {
                    Id_Categorie = categorie.Id_Categorie,
                    Nom_Categorie = txtAuteurModifSup.Text
                };
                Database.ModifierCategorie(ModifierUneCategorie);
                RefreshCategorie();
                txtAuteurModifSup.Text = "";
            }
        }

        private void formModitSupprAuteur_Load(object sender, EventArgs e)
        {
            RefreshCategorie();
            lstCategories.DisplayMember = "Nom_Categorie";
            lstCategories.ValueMember = "Id_categorie";
        }

        private void btnSupprimerAuteur_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Database.SupprimerCategorie(lstCategories.SelectedItem as Categorie);
            }
            RefreshCategorie();
            txtAuteurModifSup.Text = "";
        }
    }
}