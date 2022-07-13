namespace Ex_05_06;
using Ex_05_06.Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Teste", "00001");

        VerificaNulo(funcionario);

        void VerificaNulo(Funcionario Object)
        {
            try
            {
                if (Object is null)
                {
                    throw new Exception("Erro ao instanciar funcionario");
                }
                Console.WriteLine(Object.Nome);
            }
            catch (Exception Erro)
            {
                throw new Exception(Erro.ToString());
            }
        }
    }
}