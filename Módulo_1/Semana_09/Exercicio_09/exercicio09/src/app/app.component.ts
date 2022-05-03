import { Component, OnInit } from '@angular/core';
import { Produto } from '../assets/exercicio09';

@Component({
  selector: 'ex09-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit, Produto {
  title = 'exercicio09';

  valorTotal: number = 0;

  nome: string = '';
  valor: number = 0;
  codigo: number = 0;
  quantidade: number = 0;
  emEstoque: boolean = true;

  sofa: Produto = {
    nome: 'Sofá 4 lugares',
    valor: 120,
    codigo: 1,
    quantidade: 30,
    emEstoque: true,
  };

  comprar(produto: Produto, quantidade: number) {
    if (produto.emEstoque) {
      if (quantidade <= produto.quantidade) {
        this.valorTotal += quantidade * produto.valor;
        produto.quantidade -= quantidade;
        if (produto.quantidade === 0) {
          produto.emEstoque = false;
        }
      } else {
        alert('Quantidade fora de estoque!');
      }
    } else {
      alert('Produto fora de estoque!');
    }
  }

  ngOnInit(): void {
    this.comprar(this.sofa, 30);
    this.comprar(this.sofa, 10);
  }
}
