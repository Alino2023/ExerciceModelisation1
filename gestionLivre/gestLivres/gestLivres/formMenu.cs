using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formLivre = new formLivres();
            formLivre.ShowDialog();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formAuteur = new formAuteurs();
            formAuteur.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formAuteur = new formAuteurs();
            formAuteur.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formLivre = new formMAJLivres();
            formLivre.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formModLivre = new formMAJLivres();
            formModLivre.ShowDialog();
        }

        private void modifierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formModLivre = new formMAJLivres();
            formModLivre.ShowDialog();
        }
    }
}