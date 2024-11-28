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
    }
}