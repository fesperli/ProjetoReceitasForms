namespace ProjetoReceitasC_
{
    partial class FormIngredientes
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
            lblID = new Label();
            lblNome = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            lblUnidadeMedida = new Label();
            txtUnidadeMedida = new TextBox();
            lstIngredientes = new ListBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(107, 92);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(107, 138);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(211, 89);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(211, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // lblUnidadeMedida
            // 
            lblUnidadeMedida.AutoSize = true;
            lblUnidadeMedida.Location = new Point(107, 192);
            lblUnidadeMedida.Name = "lblUnidadeMedida";
            lblUnidadeMedida.Size = new Size(51, 15);
            lblUnidadeMedida.TabIndex = 4;
            lblUnidadeMedida.Text = "Unidade";
            // 
            // txtUnidadeMedida
            // 
            txtUnidadeMedida.Location = new Point(211, 186);
            txtUnidadeMedida.Name = "txtUnidadeMedida";
            txtUnidadeMedida.Size = new Size(100, 23);
            txtUnidadeMedida.TabIndex = 5;
            // 
            // lstIngredientes
            // 
            lstIngredientes.FormattingEnabled = true;
            lstIngredientes.Location = new Point(354, 89);
            lstIngredientes.Name = "lstIngredientes";
            lstIngredientes.Size = new Size(120, 169);
            lstIngredientes.TabIndex = 6;
            lstIngredientes.SelectedIndexChanged += lstIngredientes_SelectedIndexChanged;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(545, 86);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(85, 35);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(545, 135);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 33);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(545, 181);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(545, 228);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(85, 30);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(lstIngredientes);
            Controls.Add(txtUnidadeMedida);
            Controls.Add(lblUnidadeMedida);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Name = "FormIngredientes";
            Text = "FormIngredientes";
            Load += FormIngredientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNome;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lblUnidadeMedida;
        private TextBox txtUnidadeMedida;
        private ListBox lstIngredientes;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}