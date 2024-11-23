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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnLivres_Click(object sender, EventArgs e)
        {
            Form formLivre = new formLivres();
            formLivre.ShowDialog();
        }

        private void btnAuteurs_Click(object sender, EventArgs e)
        {
            Form formAuteur = new formAuteurs();
            formAuteur.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Form formCategorie = new formCategories();
            formCategorie.ShowDialog();
        }
    }
}