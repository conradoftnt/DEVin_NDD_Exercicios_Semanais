using GeraEstoque.Repositories;

namespace GeraEstoque.Screens
{
    public static class MenuScreen
    {
        public static void Iniciar(ProdutoRepository ListaProdutos)
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");
            Console.WriteLine("----------------------------------------");
            Console.Write(@"1 - Cadastrar produto
2 - Consultar produto
3 - Modificar produto
4 - Excluir produto
5 - Listar todos os produtos
0 - Sair

Digite a opção: ");

            var opcao = Console.ReadLine();

            Console.Write(Environment.NewLine);

            switch (opcao)
            {
                case "1":
                    CriarProdutoScreen.Iniciar(ListaProdutos);
                    Iniciar(ListaProdutos);
                    break;

                case "5":
                    ListarProdutosScreen.Iniciar(ListaProdutos);
                    Iniciar(ListaProdutos);
                    break;

                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Iniciar(ListaProdutos);
                    break;
            }
        }
    }
}