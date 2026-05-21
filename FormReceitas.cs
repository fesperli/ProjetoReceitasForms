using GerenciadorReceitas.Models;
using GerenciadorReceitas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoReceitasC_
{
    public partial class FormReceitas : Form
    {
        private RepositorioReceita repositorioReceita = new RepositorioReceita();
        private RepositorioCategoria repositorioCategoria = new RepositorioCategoria();
        private RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public FormReceitas()
        {
            InitializeComponent();
        }

        private void FormReceitas_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            CarregarLista();
        }
        private void CarregarCombos()
        {
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = repositorioCategoria.Listar();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource = repositorioUsuario.Listar();
            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember = "Id";
        }

        private void CarregarLista()
        {
            lstReceitas.DataSource = null;
            lstReceitas.DataSource = repositorioReceita.Listar();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtTempoPreparo.Clear();
            txtModoPreparo.Clear();

            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;

            if (cmbUsuario.Items.Count > 0)
                cmbUsuario.SelectedIndex = 0;

            txtNome.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da receita.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModoPreparo.Text))
            {
                MessageBox.Show("Informe o modo de preparo.");
                return false;
            }

            if (!int.TryParse(txtTempoPreparo.Text, out int tempo) || tempo <= 0)
            {
                MessageBox.Show("Informe um tempo válido.");
                return false;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria.");
                return false;
            }

            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário.");
                return false;
            }

            return true;
        }

        private Receita MontarReceita()
        {
            return new Receita
            {
                Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text,
                TempoPreparo = int.Parse(txtTempoPreparo.Text),
                ModoPreparo = txtModoPreparo.Text,
                CategoriaId = (int)cmbCategoria.SelectedValue,
                UsuarioId = (int)cmbUsuario.SelectedValue
            };
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                repositorioReceita.Inserir(MontarReceita());

                MessageBox.Show("Receita cadastrada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar receita: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Selecione uma receita.");
                    return;
                }

                repositorioReceita.Editar(MontarReceita());

                MessageBox.Show("Receita editada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar receita: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstReceitas.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma receita.");
                    return;
                }

                Receita receita = (Receita)lstReceitas.SelectedItem;

                if (MessageBox.Show("Deseja excluir esta receita?", "Confirmação",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repositorioReceita.Deletar(receita.Id);
                    MessageBox.Show("Receita excluída com sucesso.");
                    LimparCampos();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir receita: " + ex.Message);
            }
        }

        private void lstReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceitas.SelectedItem is Receita receita)
            {
                txtId.Text = receita.Id.ToString();
                txtNome.Text = receita.Nome;
                txtTempoPreparo.Text = receita.TempoPreparo.ToString();
                txtModoPreparo.Text = receita.ModoPreparo;
                cmbCategoria.SelectedValue = receita.CategoriaId;
                cmbUsuario.SelectedValue = receita.UsuarioId;
            }
        }
    }
}
