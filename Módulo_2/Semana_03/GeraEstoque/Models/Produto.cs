namespace GeraEstoque.Models
{
    public class Produto
    {
        public Guid Id;
        public string? Nome;
        public int Quantidade;
        public float Custo;
        public float Venda;

        public Produto()
        {
        }

        public Produto(string newName, int newQuant, float newCusto, float newVenda)
        {
            Id = Guid.NewGuid();
            Nome = newName;
            Quantidade = newQuant;
            Custo = newCusto;
            Venda = newVenda;
        }

        public override string ToString() => $"Produto: Id: {Id} |  Nome: {Nome} | Qtd: {Quantidade} | R$ Compra: {Custo} | R$ Venda: {Venda}";
    }
}