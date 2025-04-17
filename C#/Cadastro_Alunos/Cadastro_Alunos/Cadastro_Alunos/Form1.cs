namespace Cadastro_Alunos
{
    public partial class Form1 : Form
    {
        private int id = 1;

        public Form1()
        {
            InitializeComponent();
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("nome", "Nome");
            grid.Columns.Add("curso", "Curso");
            grid.Columns.Add("datadenasc", "Data de Nascimento");
            grid.Columns.Add("sexo", "Sexo");
        }


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.ShowDialog();
            if (cadastro.resposta != null)
            {
                cadastro.resposta[0] = id++;
                grid.Rows.Add(cadastro.resposta);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                //Coleta os valores da grid
                int id = Convert.ToInt16(grid.SelectedRows[0].Cells["id"].Value.ToString());
                String nome = grid.SelectedRows[0].Cells["nome"].Value.ToString();
                String curso = grid.SelectedRows[0].Cells["curso"].Value.ToString();
                String datadenasc = grid.SelectedRows[0].Cells["datadenasc"].Value.ToString();
                String sexo = grid.SelectedRows[0].Cells["sexo"].Value.ToString();

                //Cria o form enviando os valores
                Form2 cadastro = new Form2(id, nome, curso, datadenasc, sexo);
                cadastro.ShowDialog();

                //Volta do form em caso onde foi apertado o botao salvar
                if (cadastro.resposta != null)
                {
                    //indice que será alterado
                    int indice = grid.SelectedRows[0].Index;
                    //alteracao
                    grid.Rows[indice].SetValues(cadastro.resposta);
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(grid.SelectedRows.Count > 0)
            {
                int indice = grid.SelectedRows[0].Index;
                grid.Rows.RemoveAt(indice);
            }
        }
    }
}
