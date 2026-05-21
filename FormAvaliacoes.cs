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
    public partial class FormAvaliacoes : Form
    {
        private RepositorioAvaliacao repositorioAvaliacao = new RepositorioAvaliacao();
        private RepositorioReceita repositorioReceita = new RepositorioReceita();
        private RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public FormAvaliacoes()
        {
            InitializeComponent();
        }
        private void FormAvaliacoes_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            CarregarLista();
        }
        private void CarregarCombos()
        {
            cmbReceita.DataSource = null;
            cmbReceita.DataSource = repositorioReceita.Listar();
            cmbReceita.DisplayMember = "Nome";
            cmbReceita.ValueMember = "Id";

            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource = repositorioUsuario.Listar();
            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember = "Id";
        }

        private void CarregarLista()
        {
            lstAvaliacoes.DataSource = null;
            lstAvaliacoes.DataSource = repositorioAvaliacao.Listar();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNota.Clear();
            txtComentario.Clear();

            if (cmbReceita.Items.Count > 0)
                cmbReceita.SelectedIndex = 0;

            if (cmbUsuario.Items.Count > 0)
                cmbUsuario.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (cmbReceita.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma receita.");
                return false;
            }

            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário.");
                return false;
            }

            if (!int.TryParse(txtNota.Text, out int nota) || nota < 1 || nota > 5)
            {
                MessageBox.Show("A nota deve ser de 1 a 5.");
                return false;
            }

            return true;
        }

        private Avaliacao MontarAvaliacao()
        {
            return new Avaliacao
            {
                Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : int.Parse(txtId.Text),
                ReceitaId = (int)cmbReceita.SelectedValue,
                UsuarioId = (int)cmbUsuario.SelectedValue,
                Nota = int.Parse(txtNota.Text),
                Comentario = txtComentario.Text
            };
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

                repositorioAvaliacao.Inserir(MontarAvaliacao());

                MessageBox.Show("Avaliação cadastrada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar avaliação: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Selecione uma avaliação.");
                    return;
                }

                repositorioAvaliacao.Editar(MontarAvaliacao());

                MessageBox.Show("Avaliação editada com sucesso.");
                LimparCampos();
                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar avaliação: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAvaliacoes.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma avaliação.");
                    return;
                }

                Avaliacao avaliacao = (Avaliacao)lstAvaliacoes.SelectedItem;

                if (MessageBox.Show("Deseja excluir esta avaliação?", "Confirmação",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repositorioAvaliacao.Deletar(avaliacao.Id);
                    MessageBox.Show("Avaliação excluída com sucesso.");
                    LimparCampos();
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir avaliação: " + ex.Message);
            }
        }

        private void lstAvaliacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvaliacoes.SelectedItem is Avaliacao avaliacao)
            {
                txtId.Text = avaliacao.Id.ToString();
                txtNota.Text = avaliacao.Nota.ToString();
                txtComentario.Text = avaliacao.Comentario;
                cmbReceita.SelectedValue = avaliacao.ReceitaId;
                cmbUsuario.SelectedValue = avaliacao.UsuarioId;
            }
        }
    }
}
