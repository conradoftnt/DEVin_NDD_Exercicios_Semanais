using Semana_04.Models;

namespace Semana_04.Screens;

public class FormatacaoScreen
{
    public static void Start(FichaInscricao Usuario)
    {
        Console.Clear();

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