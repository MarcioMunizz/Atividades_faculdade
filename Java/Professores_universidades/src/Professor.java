public abstract class Professor {
    protected String nome;
    protected int quantidadeHoras;
    protected float valorHora;

    public Professor(String nome,int quantidadeHoras, float valorHora){
        this.nome = nome;
        this.quantidadeHoras = quantidadeHoras;
        this.valorHora = valorHora;
    }
    public abstract float calcularSalario();
}
