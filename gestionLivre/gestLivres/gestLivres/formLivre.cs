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

        private void Rafraichir()
        {
            lstLivres.Items.Clear();
            foreach (Livre livre in Database)
            {
                lstLivres.Items.Add(livre);
            }
        }

        private void tabCategories_Click(object sender, EventArgs e)
        {
        }

        private void tabLivres_Click(object sender, EventArgs e)
        {
            Rafraichir();
        }
    }
}