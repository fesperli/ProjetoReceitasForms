using GerenciadorReceitas.Repositories;

namespace ProjetoReceitasC_
{
    public partial class FormPrincipal : Form
    {
        private RepositorioReceita repositorioReceita = new RepositorioReceita();
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarReceitas();
        }
        private void CarregarReceitas()
        {
            try
            {
                lstReceitas.DataSource = null;
                lstReceitas.DataSource = repositorioReceita.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar receitas: " + ex.Message);
            }
        }

        private void lstReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarReceitas();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            new FormCategorias().ShowDialog();
            CarregarReceitas();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            new FormIngredientes().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FormUsuarios().ShowDialog();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            new FormReceitas().ShowDialog();
            CarregarReceitas();
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            new FormAvaliacoes().ShowDialog();
        }
    }
}
