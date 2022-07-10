using GeraEstoque.Repositories;
using GeraEstoque.Models;

namespace GeraEstoque.Screens
{
    public static class ListarProdutosScreen
    {
        public static void Iniciar(ProdutoRepository ListaProdutos)
        {


            if (ProdutoRepository.ListaProdutos.Count == 0)
            {
                Console.WriteLine("Não existem produtos registrados.");
            }
            else
            {
                Console.WriteLine("LISTA DE PRODUTOS CADASTRADOS");
                Console.WriteLine("----------------------------------------");

                foreach (Produto item in ProdutoRepository.ListaProdutos)
                {
                    Console.WriteLine(item.ToString());
                };
            }

            Console.Write(Environment.NewLine);
            Console.Write("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}