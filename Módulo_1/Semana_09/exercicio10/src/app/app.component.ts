import { Component, OnInit } from '@angular/core';
import { Aluno, Nota } from '../assets/exercicio10';

@Component({
  selector: 'ex10-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent extends Aluno implements OnInit {
  title = 'exercicio10';
  media: number = 0;
  override passou: boolean = false;

  ngOnInit(): void {
    let aluno1: Aluno = new Aluno();
    aluno1.nome = 'Jonas';
    aluno1.matricula = 7;

    let notas: Nota[] = [
      {
        cadeira: 'Geografia',
        ponto: 4,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 8,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 3,
        aluno: aluno1,
      },
      {
        cadeira: 'Geografia',
        ponto: 10,
        aluno: aluno1,
      },
    ];

    notas.forEach((nota) => {
      this.media += nota.ponto;
    });

    this.media = this.media / notas.length;

    this.passou = this.aprovado(this.media);
  }
}
