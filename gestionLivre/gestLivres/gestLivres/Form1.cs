namespace gestLivres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListeLivres_Click(object sender, EventArgs e)
        {
            formLivre formLivre = new formLivre();
            formLivre.ShowDialog();
        }
    }
}