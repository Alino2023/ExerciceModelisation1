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
    public partial class formMAJLivres : Form
    {
        public formMAJLivres()
        {
            InitializeComponent();
        }

        private void formMAJLivres_Load(object sender, EventArgs e)
        {
            RefreshCategorie();
            lstCategories.DisplayMember = "Nom_Categorie";
            lstCategories.ValueMember = "Id_categorie";
        }

        private void RefreshLivres()
        {
            lstCategories.Items.Clear();

            foreach (Livre p in Database.GetLivres())
            {
                lstCategories.Items.Add(p);
            }
        }

        private void btnModifierLivre_Click(object sender, EventArgs e)
        {
            //if (lstLivres.SelectedItems != null)
            //{
            //    Livre livre = (Livre)lstLivres.SelectedItem;
            //    Livre ModifierUneLivre = new()
            //    {
            //        Id_livre = livre.Id_livre,
            //        Titre = livre.Titre,
            //    };
            //    Database.ModifierCategorie(ModifierUneCategorie);
            //    RefreshCategorie();
            //}
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Categorie categorie = (Categorie)lstCategories.SelectedItem;
                Categorie ModifierUneCategorie = new()
                {
                    Id_Categorie = categorie.Id_Categorie,
                    Nom_Categorie = txtLivre.Text
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
    }
}