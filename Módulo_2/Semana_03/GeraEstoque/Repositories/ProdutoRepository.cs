using GeraEstoque.Models;

namespace GeraEstoque.Repositories;

public class ProdutoRepository
{
    public static IList<Produto> ListaProdutos;

    public ProdutoRepository()
    {
        ListaProdutos = new List<Produto>();
    }
}
