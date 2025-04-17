using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Alunos
{
    public partial class Form2 : Form
    {
        private int id;
        public Object[] resposta;

        public Form2()
        {
            InitializeComponent();
            cmbCurso.Items.AddRange(new string[] { "Sistemas de Informação", "Como Treinar Seu Dragão" });
        }

        public Form2(int id, string nome, string curso, string data_nasc, string sexo)
        {
            InitializeComponent();
            this.id = id;
            txtNome.Text = nome;
            cmbCurso.Items.AddRange(new string[] { "Sistemas de Informação", "Como Treinar Seu Dragão" });
            cmbCurso.Text = curso;
            dtp_Nasc.Value = DateTime.Parse(data_nasc);
            if (sexo == "Masculino")
                rdbt_masc.Checked = true;
            else
                rdbt_Fem.Checked = true;

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sexo = rdbt_masc.Checked ? "Masculino" : "Feminino";
            resposta = [id, txtNome.Text, cmbCurso.Text, dtp_Nasc.Value.ToShortDateString(), sexo];

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resposta = null;
            this.Close();
        }
    }
}
