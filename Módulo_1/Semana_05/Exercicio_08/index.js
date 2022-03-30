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
    calcularTotal(){
        let valorTotal = 0;
        this.listaProdutos.forEach(produto => {
            valorTotal += produto.quantidade * produto.preco;
        });
        return valorTotal;
    }
}

let produto_teclado = new Produto("teclado", 300, true, 1);
let produto_mouse = new Produto("mouse", 100, true, 1);
let produto_monitor = new Produto("monitor", 1000, true, 2);
let produto_gabinete = new Produto("gabinete", 500, true, 1);
let produto_livro = new Produto("livro", 100, false, 26);

let pedido_conrado = new Pedido(2022001, "Conrado");
let pedido_michael = new Pedido(2022002, "Michael");

pedido_conrado.adicionarProduto(produto_monitor);
pedido_conrado.adicionarProduto(produto_gabinete);
pedido_conrado.adicionarProduto(produto_livro);
pedido_michael.adicionarProduto(produto_mouse);
pedido_michael.adicionarProduto(produto_teclado);

pedido_conrado.listaProdutos.forEach(produto => {
    console.log(`Produto: ${produto.nome} | Valor un: R$${produto.preco} | Total: R$${produto.preco * produto.quantidade} `);
})

pedido_michael.listaProdutos.forEach(produto => {
    console.log(`Produto: ${produto.nome} | Valor un: R$${produto.preco} | Total: R$${produto.preco * produto.quantidade} `);
})

console.log(`Preço total do pedido: R$${pedido_conrado.calcularTotal( )}`)

console.log(`Preço total do pedido: R$${pedido_michael.calcularTotal( )}`)