namespace Cadastro_Alunos
{
    partial class Form2
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
            lbl_sexo = new Label();
            lblNasc = new Label();
            lblTipo = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dtp_Nasc = new DateTimePicker();
            rdbt_masc = new RadioButton();
            rdbt_Fem = new RadioButton();
            cmbCurso = new ComboBox();
            SuspendLayout();
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Location = new Point(32, 218);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(31, 15);
            lbl_sexo.TabIndex = 17;
            lbl_sexo.Text = "Sexo";
            // 
            // lblNasc
            // 
            lblNasc.AutoSize = true;
            lblNasc.Location = new Point(32, 155);
            lblNasc.Name = "lblNasc";
            lblNasc.Size = new Size(112, 15);
            lblNasc.TabIndex = 16;
            lblNasc.Text = "Data de nascimento";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(32, 90);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(38, 15);
            lblTipo.TabIndex = 15;
            lblTipo.Text = "Curso";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 13;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(32, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(130, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(211, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtp_Nasc
            // 
            dtp_Nasc.Location = new Point(32, 182);
            dtp_Nasc.Name = "dtp_Nasc";
            dtp_Nasc.Size = new Size(254, 23);
            dtp_Nasc.TabIndex = 20;
            // 
            // rdbt_masc
            // 
            rdbt_masc.AutoSize = true;
            rdbt_masc.Location = new Point(32, 240);
            rdbt_masc.Name = "rdbt_masc";
            rdbt_masc.Size = new Size(80, 19);
            rdbt_masc.TabIndex = 21;
            rdbt_masc.TabStop = true;
            rdbt_masc.Text = "Masculino";
            rdbt_masc.UseVisualStyleBackColor = true;
            // 
            // rdbt_Fem
            // 
            rdbt_Fem.AutoSize = true;
            rdbt_Fem.Location = new Point(138, 240);
            rdbt_Fem.Name = "rdbt_Fem";
            rdbt_Fem.Size = new Size(78, 19);
            rdbt_Fem.TabIndex = 22;
            rdbt_Fem.TabStop = true;
            rdbt_Fem.Text = "Femenino";
            rdbt_Fem.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(32, 118);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(254, 23);
            cmbCurso.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 348);
            Controls.Add(cmbCurso);
            Controls.Add(rdbt_Fem);
            Controls.Add(rdbt_masc);
            Controls.Add(dtp_Nasc);
            Controls.Add(lbl_sexo);
            Controls.Add(lblNasc);
            Controls.Add(lblTipo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_sexo;
        private Label lblNasc;
        private Label lblTipo;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnSalvar;
        private Button btnCancelar;
        private DateTimePicker dtp_Nasc;
        private RadioButton rdbt_masc;
        private RadioButton rdbt_Fem;
        private ComboBox cmbCurso;
    }
}