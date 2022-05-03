interface Pessoa {
    nome: string;
    idade: number;
    rua: string;
    cadastrar(): void;
}

class Aluno implements Pessoa {
    nome: string;
    idade: number;
    rua: string;
    matricula: number;
    cadeiras: string[];
    constructor(
        nome: string,
        idade: number,
        rua: string,
        matricula: number,
        cadeiras: string[],
    ) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }
    cadastrar(): void {
        console.log(this);
    }
}

class Funcionario implements Pessoa {
    nome: string;
    idade: number;
    rua: string;
    identificador: number;
    setor: string;
    constructor(
        nome: string,
        idade: number,
        rua: string,
        identificador: number,
        setor: string,
    ) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.identificador = identificador;
        this.setor = setor;
    }
    cadastrar(): void {
        console.log(this);
    }
}
