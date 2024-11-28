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
    }
}