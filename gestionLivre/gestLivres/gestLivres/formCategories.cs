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
    public partial class formCategories : Form
    {
        public formCategories()
        {
            InitializeComponent();
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            RefreshCategorie();
            lstCategories.DisplayMember = "Nom_Categorie";
            lstCategories.ValueMember = "Id_categorie";
        }

        private void RefreshCategorie()
        {
            lstCategories.Items.Clear();

            foreach (Categorie c in Database.GetCategorie())
            {
                lstCategories.Items.Add(c);
            }
        }

        private void btnAjouterCategorie_Click(object sender, EventArgs e)
        {
            Categorie categorie = new()
            {
                Nom_Categorie = txtAjoutCategorie.Text
            };
            Database.AjoutCategorie(categorie);
            RefreshCategorie();
            txtAjoutCategorie.Text = "";
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedItems != null)
            {
                Categorie categorie = (Categorie)lstCategories.SelectedItem;
                Categorie ModifierUneCategorie = new()
                {
                    Id_Categorie = categorie.Id_Categorie,
                    Nom_Categorie = txtModifCategorie.Text
                };
                Database.ModifierCategorie(ModifierUneCategorie);
                RefreshCategorie();
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