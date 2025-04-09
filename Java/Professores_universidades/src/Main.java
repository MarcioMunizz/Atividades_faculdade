class Principal {
    public static void main(String[] args) {
        ProfessorOrientador orientador = new ProfessorOrientador(
                "Dr. João", 20, 50.0f, 5, 2);
        ProfessorPesquisador pesquisador = new ProfessorPesquisador(
                "Dra. Ana", 20, 50.0f, 40, 60.0f);

        System.out.println("Salário do Professor Orientador: R$ " + orientador.calcularSalario());
        System.out.println("Salário do Professor Pesquisador: R$ " + pesquisador.calcularSalario());
    }
}

