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
            Form formLivres = new Form();
            formLivres.ShowDialog();
        }
    }
}