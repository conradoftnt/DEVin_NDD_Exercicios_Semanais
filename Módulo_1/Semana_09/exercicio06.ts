class Conta {
    protected numero: number;
    protected saldo: number;
    protected estaAtiva: boolean;
    protected dono: string;

    constructor(
        numero: number,
        saldo: number,
        estaAtiva: boolean,
        dono: string,
    ) {
        this.numero = numero;
        this.saldo = saldo;
        this.estaAtiva = estaAtiva;
        this.dono = dono;
    }
}

class ContaEmpresa extends Conta {
    private limiteDeDeposito: number = 1000;
    deposito(valor: number) {
        if (valor <= this.limiteDeDeposito) {
            this.saldo += valor;
        }
    }
    imprimeValorConta() {
        console.log(this.saldo);
    }
}

let minhaEmpresa = new ContaEmpresa(1, 0, true, "Conrado");

minhaEmpresa.deposito(1000);
minhaEmpresa.deposito(1000);
minhaEmpresa.deposito(1000);
minhaEmpresa.deposito(500);
minhaEmpresa.imprimeValorConta();
