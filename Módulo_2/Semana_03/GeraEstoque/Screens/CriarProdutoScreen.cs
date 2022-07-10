using GeraEstoque.Repositories;
using GeraEstoque.Models;

namespace GeraEstoque.Screens
{
    public static class CriarProdutoScreen
    {
        public static void Iniciar(ProdutoRepository ListaProdutos)
        {

            Console.Write("Digite o nome do produto a ser cadastrado: ");
            string? nome = Console.ReadLine();

            Console.Write("Digite quantas unidades do produto estão disponíveis no estoque: ");
            int qntEstoque = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da compra do produto: ");
            float vlrCompra = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de venda do produto: ");
            float vlrVenda = float.Parse(Console.ReadLine());

            Guid productId = Guid.NewGuid();

            Produto NewProduto = new Produto(nome, qntEstoque, vlrCompra, vlrVenda);

            ProdutoRepository.ListaProdutos.Add(NewProduto);

            Console.Write(Environment.NewLine);
            Console.Write("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Write(Environment.NewLine);
            Console.Clear();
        }
    }
}