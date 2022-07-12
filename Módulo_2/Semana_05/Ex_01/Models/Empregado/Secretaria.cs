namespace Ex_01.Models;

class Secretaria : SalarioEmpregado
{
    public int QtdAnosEmpresa;
    public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa) : base(id, nome, codigoFuncionario, valorSalario)
    {
        QtdAnosEmpresa = qtdAnosEmpresa;
    }

    public void AtenderCliente()
    {

    }

    public void RealizarLigacoes()
    {

    }
}