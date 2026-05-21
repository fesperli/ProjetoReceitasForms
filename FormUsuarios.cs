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
    public partial class FormUsuarios : Form
    {
        private RepositorioUsuario repositorio = new RepositorioUsuario();
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = repositorio.Listar();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do usuário.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Informe o e-mail.");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("E-mail inválido.");
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

                Usuario usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text
                };

                repositorio.Inserir(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso.");
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
                    MessageBox.Show("Selecione um usuário.");
                    return;
                }

                Usuario usuario = new Usuario
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text,
                    Email = txtEmail.Text
                };

                repositorio.Editar(usuario);

                MessageBox.Show("Usuário editado com sucesso.");
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
                if (lstUsuarios.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um usuário.");
                    return;
                }

                Usuario usuario = (Usuario)lstUsuarios.SelectedItem;

                if (MessageBox.Show("Deseja excluir este usuário?", "Confirmação",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repositorio.Deletar(usuario.Id);
                    MessageBox.Show("Usuário excluído com sucesso.");
                    LimparCampos();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir. Talvez o usuário esteja vinculado a uma receita ou avaliação. " + ex.Message);
            }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedItem is Usuario usuario)
            {
                txtId.Text = usuario.Id.ToString();
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
            }
        }
    }
}
