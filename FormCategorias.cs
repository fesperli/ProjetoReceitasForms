using GerenciadorReceitas.Models;
using GerenciadorReceitas.Repositories;
using ProjetoReceitasC_.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoReceitasC_
{
    public partial class FormCategorias : Form
    {
        private RepositorioCategoria repositorio = new RepositorioCategoria();
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }
        private void CarregarLista()
        {
            lstCategorias.DataSource = null;
            lstCategorias.DataSource = repositorio.Listar();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da categoria.");
                return false;
            }
            return true;
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

                Categoria categoria = new Categoria
                {
                    Nome = txtNome.Text
                };

                repositorio.Inserir(categoria);

                MessageBox.Show("Categoria cadastrada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Selecione uma categoria.");
                    return;
                }

                Categoria categoria = new Categoria
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text
                };

                repositorio.Editar(categoria);

                MessageBox.Show("Categoria editada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCategorias.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma categoria.");
                    return;
                }

                Categoria categoria = (Categoria)lstCategorias.SelectedItem;

                DialogResult resposta = MessageBox.Show(
                    "Deseja excluir esta categoria?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);

                if (resposta == DialogResult.Yes)
                {
                    repositorio.Deletar(categoria.Id);
                    MessageBox.Show("Categoria excluída com sucesso.");
                    LimparCampos();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. Talvez a categoria esteja sendo usada em uma receita. " + ex.Message);
            }
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem is Categoria categoria)
            {
                txtId.Text = categoria.Id.ToString();
                txtNome.Text = categoria.Nome;
            }
        }
    }
}
