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
    public partial class FormIngredientes : Form
    {
        private RepositorioIngrediente repositorio = new RepositorioIngrediente();
        public FormIngredientes()
        {
            InitializeComponent();
        }

        private void FormIngredientes_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            lstIngredientes.DataSource = null;
            lstIngredientes.DataSource = repositorio.Listar();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtUnidadeMedida.Clear();
            txtNome.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do ingrediente.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnidadeMedida.Text))
            {
                MessageBox.Show("Informe a unidade de medida.");
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

                Ingrediente ingrediente = new Ingrediente
                {
                    Nome = txtNome.Text,
                    UnidadeMedida = txtUnidadeMedida.Text
                };

                repositorio.Inserir(ingrediente);

                MessageBox.Show("Ingrediente cadastrado com sucesso.");
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
                    MessageBox.Show("Selecione um ingrediente.");
                    return;
                }

                Ingrediente ingrediente = new Ingrediente
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text,
                    UnidadeMedida = txtUnidadeMedida.Text
                };

                repositorio.Editar(ingrediente);

                MessageBox.Show("Ingrediente editado com sucesso.");
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
                if (lstIngredientes.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um ingrediente.");
                    return;
                }

                Ingrediente ingrediente = (Ingrediente)lstIngredientes.SelectedItem;

                if (MessageBox.Show("Deseja excluir este ingrediente?", "Confirmação",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repositorio.Deletar(ingrediente.Id);
                    MessageBox.Show("Ingrediente excluído com sucesso.");
                    LimparCampos();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. Talvez o ingrediente esteja sendo usado em uma receita. " + ex.Message);
            }
        }

        private void lstIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIngredientes.SelectedItem is Ingrediente ingrediente)
            {
                txtId.Text = ingrediente.Id.ToString();
                txtNome.Text = ingrediente.Nome;
                txtUnidadeMedida.Text = ingrediente.UnidadeMedida;
            }
        }
    }
}
