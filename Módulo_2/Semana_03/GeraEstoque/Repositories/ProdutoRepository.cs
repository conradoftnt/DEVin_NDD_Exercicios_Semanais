using GeraEstoque.Models;

namespace GeraEstoque.Repositories
{
    public class ProdutoRepository
    {
        IList<Produto>? ListaProdutos;

        public ProdutoRepository()
        {
            ListaProdutos = new List<Produto>();
        }
    }
}