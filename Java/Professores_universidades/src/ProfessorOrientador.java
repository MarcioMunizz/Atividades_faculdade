public class ProfessorOrientador extends Professor{
    private int quantAlunosOrientados;
    private  int horasPorOientado;

    public ProfessorOrientador(String nome, int quantidadeHoras, float valorHora,
                               int quantAlunosOrOientados, int horasPorOientado){

        super(nome, quantidadeHoras,valorHora);
        this.quantAlunosOrientados = quantAlunosOrientados;
        this.horasPorOientado = horasPorOientado;
    }
    @Override
    public float calcularSalario() {
        return (quantidadeHoras * valorHora * 5.25f) +
                (quantAlunosOrientados * horasPorOientado * valorHora);
    }
}
