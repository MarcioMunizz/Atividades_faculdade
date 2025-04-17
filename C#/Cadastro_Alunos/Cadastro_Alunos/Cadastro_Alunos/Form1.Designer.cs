namespace Cadastro_Alunos
{
    partial class Form1
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
            grid = new DataGridView();
            btn_inserir = new Button();
            btn_alterar = new Button();
            btn_excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(45, 12);
            grid.Name = "grid";
            grid.Size = new Size(715, 313);
            grid.TabIndex = 0;
            // 
            // btn_inserir
            // 
            btn_inserir.Location = new Point(101, 375);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(75, 23);
            btn_inserir.TabIndex = 1;
            btn_inserir.Text = "Inserir";
            btn_inserir.UseVisualStyleBackColor = true;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(368, 375);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(75, 23);
            btn_alterar.TabIndex = 2;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(642, 375);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 23);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(btn_inserir);
            Controls.Add(grid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid;
        private Button btn_inserir;
        private Button btn_alterar;
        private Button btn_excluir;
    }
}
