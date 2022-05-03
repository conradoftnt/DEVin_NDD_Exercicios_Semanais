class Pessoa {
    nome: string;
    idade: number;
    rua: string;
    cadastrar() {
        console.log(this);
    }
    constructor(nome: string, idade: number, rua: string) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
    }
}

class Aluno extends Pessoa {
    matricula: number;
    cadeiras: string[];
    constructor(
        nome: string,
        idade: number,
        rua: string,
        matricula: number,
        cadeiras: string[],
    ) {
        super(nome, idade, rua);
        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }
}

class Funcionario extends Pessoa {
    identificador: number;
    setor: string;
    constructor(
        nome: string,
        idade: number,
        rua: string,
        identificador: number,
        setor: string,
    ) {
        super(nome, idade, rua);
        this.identificador = identificador;
        this.setor = setor;
    }
}
