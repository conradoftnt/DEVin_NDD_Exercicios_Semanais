namespace Ex_01.Models;

class SalarioEmpregado : Empregado
{
    public int CodigoFuncionario;
    public double ValorSalario;

    public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario) : base(id, nome)
    {
        CodigoFuncionario = codigoFuncionario;
        ValorSalario = valorSalario;
    }

    public void CalcularFolhaPagamento()
    {

    }
}