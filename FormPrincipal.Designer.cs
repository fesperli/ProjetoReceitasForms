namespace ProjetoReceitasC_
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstReceitas = new ListBox();
            btnAtualizar = new Button();
            btnCategorias = new Button();
            btnReceitas = new Button();
            btnIngredientes = new Button();
            btnUsuarios = new Button();
            btnAvaliacoes = new Button();
            SuspendLayout();
            // 
            // lstReceitas
            // 
            lstReceitas.FormattingEnabled = true;
            lstReceitas.Location = new Point(56, 66);
            lstReceitas.Name = "lstReceitas";
            lstReceitas.Size = new Size(265, 184);
            lstReceitas.TabIndex = 0;
            lstReceitas.SelectedIndexChanged += lstReceitas_SelectedIndexChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(357, 85);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(87, 36);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(484, 85);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(87, 36);
            btnCategorias.TabIndex = 2;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnReceitas
            // 
            btnReceitas.Location = new Point(357, 151);
            btnReceitas.Name = "btnReceitas";
            btnReceitas.Size = new Size(87, 36);
            btnReceitas.TabIndex = 3;
            btnReceitas.Text = "Receitas";
            btnReceitas.UseVisualStyleBackColor = true;
            btnReceitas.Click += btnReceitas_Click;
            // 
            // btnIngredientes
            // 
            btnIngredientes.Location = new Point(357, 214);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(87, 36);
            btnIngredientes.TabIndex = 4;
            btnIngredientes.Text = "Ingredientes";
            btnIngredientes.UseVisualStyleBackColor = true;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(484, 151);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(87, 36);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAvaliacoes
            // 
            btnAvaliacoes.Location = new Point(484, 214);
            btnAvaliacoes.Name = "btnAvaliacoes";
            btnAvaliacoes.Size = new Size(87, 36);
            btnAvaliacoes.TabIndex = 6;
            btnAvaliacoes.Text = "Avaliacoes";
            btnAvaliacoes.UseVisualStyleBackColor = true;
            btnAvaliacoes.Click += btnAvaliacoes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvaliacoes);
            Controls.Add(btnUsuarios);
            Controls.Add(btnIngredientes);
            Controls.Add(btnReceitas);
            Controls.Add(btnCategorias);
            Controls.Add(btnAtualizar);
            Controls.Add(lstReceitas);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstReceitas;
        private Button btnAtualizar;
        private Button btnCategorias;
        private Button btnReceitas;
        private Button btnIngredientes;
        private Button btnUsuarios;
        private Button btnAvaliacoes;
    }
}
