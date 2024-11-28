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
            RefreshLivres();
            lstLivres.DisplayMember = "Titre";
            lstLivres.ValueMember = "Id_livre";
        }

        private void RefreshLivres()
        {
            lstLivres.Items.Clear();

            foreach (Livre p in Database.GetLivres())
            {
                lstLivres.Items.Add(p);
            }
        }
    }
}