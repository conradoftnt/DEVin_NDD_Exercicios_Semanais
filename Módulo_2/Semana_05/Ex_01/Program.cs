namespace EX_01;

using Ex_01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Empregado empregado = new Empregado(1, "Empregado");

        Console.WriteLine(empregado.Id);
        Console.WriteLine(empregado.Nome);
        empregado.Trabalhar();
        empregado.IrEmbora();
        empregado.TirarFolga();

        FuncionarioHorista funcionarioHorista = new FuncionarioHorista(2, "FuncionarioHorista", "2222", 22);

        Console.WriteLine(funcionarioHorista.Id);
        Console.WriteLine(funcionarioHorista.Nome);
        Console.WriteLine(funcionarioHorista.Cnpj);
        Console.WriteLine(funcionarioHorista.Taxa);
        funcionarioHorista.Trabalhar();
        funcionarioHorista.IrEmbora();
        funcionarioHorista.TirarFolga();
        funcionarioHorista.CalcularTaxas();
        funcionarioHorista.EmitirNota();

        SalarioEmpregado salarioEmpregado = new SalarioEmpregado(3, "SalarioEmpregado", 333, 3333);

        Console.WriteLine(salarioEmpregado.Id);
        Console.WriteLine(salarioEmpregado.Nome);
        Console.WriteLine(salarioEmpregado.CodigoFuncionario);
        Console.WriteLine(salarioEmpregado.ValorSalario);
        salarioEmpregado.Trabalhar();
        salarioEmpregado.IrEmbora();
        salarioEmpregado.TirarFolga();
        salarioEmpregado.CalcularFolhaPagamento();

        Secretaria secretaria = new Secretaria(4, "Secretaria", 444, 4444, 4);

        Console.WriteLine(secretaria.Id);
        Console.WriteLine(secretaria.Nome);
        Console.WriteLine(secretaria.CodigoFuncionario);
        Console.WriteLine(secretaria.ValorSalario);
        Console.WriteLine(secretaria.QtdAnosEmpresa);
        secretaria.Trabalhar();
        secretaria.IrEmbora();
        secretaria.TirarFolga();
        secretaria.CalcularFolhaPagamento();
        secretaria.AtenderCliente();
        secretaria.RealizarLigacoes();

    }
}