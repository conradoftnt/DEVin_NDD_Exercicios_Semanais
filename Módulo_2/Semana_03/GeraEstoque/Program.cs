namespace GeraEstoque;
using GeraEstoque.Screens;
using GeraEstoque.Repositories;
class Program
{
    public static ProdutoRepository? ListaProdutos;
    static void Main(string[] args)
    {
        ListaProdutos = new ProdutoRepository();
        MenuScreen.Iniciar(ListaProdutos);
    }
}