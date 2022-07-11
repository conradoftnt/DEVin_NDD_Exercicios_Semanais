using Semana_04.Models;

namespace Semana_04.Screens
{
    public static class MenuScreen
    {

        public static void Start()
        {
            Console.WriteLine("Bem-Vindo ao exercício da semana 04 do módulo 02 do curso DEVin na turma NDD");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Preencha a ficha do usuário.");
            Console.Write(Environment.NewLine);

            Console.Write("Nome: ");
            string? Nome = Console.ReadLine();

            Console.Write("Curso: ");
            string? Curso = Console.ReadLine();

            Console.Write("Escolaridade: ");
            string? Escolaridade = Console.ReadLine();

            Console.Write("Dia de nascimento: ");
            int DiaNascimento = int.Parse(Console.ReadLine());

            Console.Write("Mês de nascimento: ");
            int MesNascimento = int.Parse(Console.ReadLine());

            Console.Write("Ano de nascimento: ");
            int AnoNascimento = int.Parse(Console.ReadLine());

            DateTime DataNascimento = new DateTime(AnoNascimento, MesNascimento, DiaNascimento);

            Console.Write("Valor do curso: ");
            float ValorCurso = float.Parse(Console.ReadLine());

            Console.Write("Valor do desconto: ");
            float ValorDesconto = float.Parse(Console.ReadLine());

            Console.Write("Valor da multa: ");
            float ValorMulta = float.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write(Environment.NewLine);

            FichaInscricao Usuario = new FichaInscricao(Nome, Curso, Escolaridade, DataNascimento, ValorCurso, ValorDesconto, ValorMulta);

            if (Usuario.ValorDesconto > 0)
            {
                if (Usuario.Idade < 18)
                {
                    Console.WriteLine(FormatacaoTexto.Formatacao(Usuario.Nome, Usuario.Curso, Usuario.ValorCurso, Usuario.ValorDesconto, Usuario.Idade));
                }
                else
                {
                    Console.WriteLine(FormatacaoTexto.Formatacao(Usuario.Nome, Usuario.Curso, Usuario.ValorCurso, Usuario.ValorDesconto));
                }
            }
            else
            {
                Console.WriteLine(FormatacaoTexto.Formatacao(Usuario.Nome, Usuario.Curso, Usuario.ValorCurso));
            }
        }
    }
}