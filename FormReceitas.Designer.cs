namespace ProjetoReceitasC_
{
    partial class FormReceitas
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
            lstReceitas = new ListBox();
            cmbCategoria = new ComboBox();
            cmbUsuario = new ComboBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTempoPreparo = new TextBox();
            lblNome = new Label();
            lblTempoPreparo = new Label();
            lblModoPreparo = new Label();
            lblCategoria = new Label();
            txtModoPreparo = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(70, 50);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(434, 177);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lstReceitas
            // 
            lstReceitas.FormattingEnabled = true;
            lstReceitas.Location = new Point(264, 98);
            lstReceitas.Name = "lstReceitas";
            lstReceitas.Size = new Size(120, 94);
            lstReceitas.TabIndex = 6;
            lstReceitas.SelectedIndexChanged += lstReceitas_SelectedIndexChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(519, 98);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 7;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(519, 169);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(139, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(139, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 10;
            // 
            // txtTempoPreparo
            // 
            txtTempoPreparo.Location = new Point(139, 140);
            txtTempoPreparo.Name = "txtTempoPreparo";
            txtTempoPreparo.Size = new Size(100, 23);
            txtTempoPreparo.TabIndex = 11;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(59, 98);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // lblTempoPreparo
            // 
            lblTempoPreparo.AutoSize = true;
            lblTempoPreparo.Location = new Point(34, 143);
            lblTempoPreparo.Name = "lblTempoPreparo";
            lblTempoPreparo.Size = new Size(88, 15);
            lblTempoPreparo.TabIndex = 13;
            lblTempoPreparo.Text = "Tempo preparo";
            // 
            // lblModoPreparo
            // 
            lblModoPreparo.AutoSize = true;
            lblModoPreparo.Location = new Point(34, 186);
            lblModoPreparo.Name = "lblModoPreparo";
            lblModoPreparo.Size = new Size(99, 15);
            lblModoPreparo.TabIndex = 14;
            lblModoPreparo.Text = "Modo de preparo";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(423, 101);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "Categoria";
            // 
            // txtModoPreparo
            // 
            txtModoPreparo.Location = new Point(139, 183);
            txtModoPreparo.Name = "txtModoPreparo";
            txtModoPreparo.Size = new Size(100, 23);
            txtModoPreparo.TabIndex = 16;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(264, 233);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(365, 233);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(264, 285);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(365, 285);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 20;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtModoPreparo);
            Controls.Add(lblCategoria);
            Controls.Add(lblModoPreparo);
            Controls.Add(lblTempoPreparo);
            Controls.Add(lblNome);
            Controls.Add(txtTempoPreparo);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbCategoria);
            Controls.Add(lstReceitas);
            Controls.Add(lblUsuario);
            Controls.Add(lblId);
            Name = "FormReceitas";
            Text = "FormReceitas";
            Load += FormReceitas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblUsuario;
        private ListBox lstReceitas;
        private ComboBox cmbCategoria;
        private ComboBox cmbUsuario;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTempoPreparo;
        private Label lblNome;
        private Label lblTempoPreparo;
        private Label lblModoPreparo;
        private Label lblCategoria;
        private TextBox txtModoPreparo;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}