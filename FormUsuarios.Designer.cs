namespace ProjetoReceitasC_
{
    partial class FormUsuarios
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
            lblNome = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lstUsuarios = new ListBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            txtNome = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(88, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(88, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.Location = new Point(335, 57);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(120, 169);
            lstUsuarios.TabIndex = 6;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(530, 56);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(87, 33);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(530, 99);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 32);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(530, 145);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 32);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(530, 194);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(87, 32);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(199, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(199, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(lstUsuarios);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtEmail;
        private ListBox lstUsuarios;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtNome;
        private TextBox txtId;
    }
}