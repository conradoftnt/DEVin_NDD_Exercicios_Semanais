using Semana_04.Models;

namespace Semana_04.Screens;

public static class MenuScreen
{

    public static void Start(FichaInscricao Usuario)
    {

        Console.Write(@"MENU DE OPÇÕES DO USUÁRIO 

1 - Mostrar formatação da ficha.
2 - Editar curso do usuário.
3 - Mostrar lista de cursos do usuário.
0 - Sair do programa.

Escolha uma das opções: ");
        string? opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                FormatacaoScreen.Start(Usuario);
                RetornaMenu(Usuario);
                break;

            case "2":
                Console.Clear();
                Console.Write("Digite o novo curso do usuário: ");
                string? NewCurso = Console.ReadLine();
                Usuario.AdicionaCurso(NewCurso);
                Console.Clear();
                Start(Usuario);
                break;

            case "3":
                Console.Clear();
                Usuario.MostraCursos();
                RetornaMenu(Usuario);
                break;

            case "0":
                Console.Clear();
                Environment.Exit(0);
                break;

            default:
                Console.Clear();
                Start(Usuario);
                break;
        }
    }

    private static void RetornaMenu(FichaInscricao Usuario)
    {
        Console.Write(Environment.NewLine);
        Console.Write("Precione qualquer tecla para voltar ao meno do usuário.");
        Console.ReadKey();
        Console.Clear();
        MenuScreen.Start(Usuario);
    }
}
