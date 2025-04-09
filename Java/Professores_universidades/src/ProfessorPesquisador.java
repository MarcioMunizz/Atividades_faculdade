public class ProfessorPesquisador extends Professor {
    private int quantidadeHorasPesquisaMensais;
    private float valorHoraPesquisa;

    public ProfessorPesquisador(String nome, int quantidadeHoras, float valorHora,
                                int quantidadeHorasPesquisaMensais, float valorHoraPesquisa){
        super (nome,quantidadeHoras,valorHora);
        this.quantidadeHorasPesquisaMensais = quantidadeHorasPesquisaMensais;
        this.valorHoraPesquisa = valorHoraPesquisa;
    }






    @Override
    public float calcularSalario(){
        return (quantidadeHoras * valorHora * 5.25f) +
                (quantidadeHorasPesquisaMensais * valorHoraPesquisa);
    }
}
