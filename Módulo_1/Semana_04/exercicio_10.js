const contasClientes = [
    {
      id: 1,
      saldo: 500
    },
    {
      id: 2,
      saldo: 30000
    },
    {
      id: 3,
      saldo: 50
    }
];

const sacar = (id,valor) => {
    let cliente = contasClientes.find(clienteId => clienteId.id === id);
    if(cliente !== undefined){
        if(valor <= 0){
            console.log("Valor inválido!");
            return;
        };
        if(valor > cliente.saldo){
            console.log(`Saldo insuficiente! Saldo atual: ${cliente.saldo}.`);
            return;
        };
        let novoSaldo = cliente.saldo - valor;
        console.log(`Seu saque ocorreu com sucesso! Seu novo saldo é: ${novoSaldo}.`);
        contasClientes.forEach(attCliente => {
            if(id === attCliente.id){
                attCliente.saldo = novoSaldo;
            };
        });        
        return;
    }
    console.log("Id não encontrado!");
    return;
};

const depositar = (id, valor) => {
    let cliente = contasClientes.find(clienteId => clienteId.id === id);
    if(cliente !== undefined){
        if(valor <= 0){
            console.log("Valor inválido!");
            return;
        };
        let novoSaldo = cliente.saldo + valor;
        contasClientes.forEach(attCliente => {
            if(id === attCliente.id){
                attCliente.saldo = novoSaldo;
            };
        });
        console.log(`Seu deposito foi realizado com sucesso! Seu novo saldo é: ${novoSaldo}.`);
        return;
    };
    console.log("Id não encontrado!");
    return;
};

sacar(1,200);

depositar(3,400);

console.log(contasClientes);