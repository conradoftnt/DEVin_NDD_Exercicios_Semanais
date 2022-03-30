class Produto {
    nome;
    preco;
    emEstoque;
    quantidade;
    constructor(nome, preco, emEstoque, quantidade){
        this.nome = nome;
        this.preco = preco;
        this.emEstoque = emEstoque;
        this.quantidade = quantidade;
    }
}

class Pedido {
    numeroPedido;
    dataPedido = new Date().toLocaleDateString();
    estaPago = false;
    listaProdutos = [];
    nomeCliente;
    constructor(numeroPedido, nomeCliente){
        this.numeroPedido = numeroPedido;
        this.nomeCliente = nomeCliente;
    }
    adicionarProduto(produto){
        if(produto instanceof Produto){
            this.listaProdutos.push(produto)
        }
    }
}