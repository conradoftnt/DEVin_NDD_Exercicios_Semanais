namespace GeraEstoque.Screens
{
    public static class MenuScreen
    {
        public static void Iniciar()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Seja bem vindo");
            Console.Write(Environment.NewLine);

            Console.Write(@"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
0  Sair

Digite a opção: ");

            var opcao = Console.ReadLine();

            Console.Write(Environment.NewLine);

            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;

                case "2":
                    Iniciar();
                    break;

                case "3":
                    Iniciar();
                    break;

                case "4":
                    Iniciar();
                    break;

                case "0":
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Iniciar();
                    break;
            }
        }

        static void CadastrarProduto()
        {
            Console.Write("Digite o nome do produto a ser cadastrado: ");
            string nome = Console.ReadLine();

            Console.Write("Digite quantas unidades do produto estão disponíveis no estoque: ");
            int qntEstoque = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da compra do produto: ");
            float vlrCompra = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de venda do produto: ");
            float vlrVenda = float.Parse(Console.ReadLine());

            Guid productId = Guid.NewGuid();

            Console.WriteLine(@$"Produto cadastrado com sucesso!

ID: {productId};
Nome: Produto {nome}; 
Qtd: {qntEstoque};
R$ Compra: R$ {vlrCompra};
R$ Venda: {vlrVenda};”.");

            Console.Write(Environment.NewLine);
            Console.Write("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Write(Environment.NewLine);
            Iniciar();
        }
    }
}