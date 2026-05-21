namespace ProjetoReceitasC_
{
    partial class FormAvaliacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblUsuario = new Label();
            lblReceita = new Label();
            lblNota = new Label();
            lblComentario = new Label();
            txtId = new TextBox();
            txtNota = new TextBox();
            txtComentario = new TextBox();
            cmbReceita = new ComboBox();
            cmbUsuario = new ComboBox();
            lstAvaliacoes = new ListBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(91, 73);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(93, 158);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblReceita
            // 
            lblReceita.AutoSize = true;
            lblReceita.Location = new Point(91, 121);
            lblReceita.Name = "lblReceita";
            lblReceita.Size = new Size(45, 15);
            lblReceita.TabIndex = 2;
            lblReceita.Text = "Receita";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(93, 201);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 3;
            lblNota.Text = "Nota";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(93, 253);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(70, 15);
            lblComentario.TabIndex = 4;
            lblComentario.Text = "Comentario";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(216, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 5;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(216, 198);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(121, 23);
            txtNota.TabIndex = 6;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(216, 250);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(121, 70);
            txtComentario.TabIndex = 7;
            // 
            // cmbReceita
            // 
            cmbReceita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReceita.FormattingEnabled = true;
            cmbReceita.Location = new Point(216, 118);
            cmbReceita.Name = "cmbReceita";
            cmbReceita.Size = new Size(121, 23);
            cmbReceita.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(216, 158);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 9;
            // 
            // lstAvaliacoes
            // 
            lstAvaliacoes.FormattingEnabled = true;
            lstAvaliacoes.Location = new Point(384, 65);
            lstAvaliacoes.Name = "lstAvaliacoes";
            lstAvaliacoes.Size = new Size(159, 259);
            lstAvaliacoes.TabIndex = 10;
            lstAvaliacoes.SelectedIndexChanged += lstAvaliacoes_SelectedIndexChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(588, 73);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(96, 42);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(588, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 42);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(588, 210);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 42);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(588, 278);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 42);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormAvaliacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(lstAvaliacoes);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbReceita);
            Controls.Add(txtComentario);
            Controls.Add(txtNota);
            Controls.Add(txtId);
            Controls.Add(lblComentario);
            Controls.Add(lblNota);
            Controls.Add(lblReceita);
            Controls.Add(lblUsuario);
            Controls.Add(lblId);
            Name = "FormAvaliacoes";
            Text = "FormAvaliacoes";
            Load += FormAvaliacoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblUsuario;
        private Label lblReceita;
        private Label lblNota;
        private Label lblComentario;
        private TextBox txtId;
        private TextBox txtNota;
        private TextBox txtComentario;
        private ComboBox cmbReceita;
        private ComboBox cmbUsuario;
        private ListBox lstAvaliacoes;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}