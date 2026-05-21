namespace ProjetoReceitasC_
{
    partial class FormCategorias
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
            txtId = new TextBox();
            lblId = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lstCategorias = new ListBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(137, 88);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(104, 96);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(137, 149);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(91, 152);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lstCategorias
            // 
            lstCategorias.FormattingEnabled = true;
            lstCategorias.Location = new Point(332, 88);
            lstCategorias.Name = "lstCategorias";
            lstCategorias.Size = new Size(120, 199);
            lstCategorias.TabIndex = 4;
            lstCategorias.SelectedIndexChanged += lstCategorias_SelectedIndexChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(524, 88);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 43);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(524, 137);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 44);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(524, 187);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 44);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(524, 237);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 43);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(lstCategorias);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "FormCategorias";
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtNome;
        private Label lblNome;
        private ListBox lstCategorias;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}