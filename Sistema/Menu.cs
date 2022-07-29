namespace Sistema
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_cad_Produtos_Click(object sender, EventArgs e)
        {
            Produtos frm = new Produtos ();
            frm.Show();
        }

        private void Btn_cad_Categorias_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.Show();
        }

        private void ProdutosToolStripMenuItem_click(object sender, EventArgs e)
        {
            Produtos frm = new Produtos();
            frm.Show();
        }
        private void CategoriasToolStripMenuItem_click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.Show();
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            Produtos frm = new Produtos();
            frm.Show();
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.Show();
        }
    }
}