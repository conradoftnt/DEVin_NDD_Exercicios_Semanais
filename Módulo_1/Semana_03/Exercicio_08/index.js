function ex08() {
    let operation = prompt(`Qual dentre as operações você deseja realizar? “+”, “-”, “*” ou “/”`);
    let num1 = Number(prompt("Digite o primeiro valor que você deseja calcular:"))
    let num2 = Number(prompt("Digite o segundo valor que você deseja calcular:"))
    let conta;
    if(operation === "+"){
        conta = num1 + num2
    } else if(operation === "-"){
        conta = num1 - num2
    } else if(operation === "*"){
        conta = num1 * num2
    } else if(operation === "/"){
        conta = num1 / num2
    } else {
        alert("Você não inseriu um operador válido!")
        return
    }
    if(isNaN(conta)){
        alert("Você não inseriu um valor válido! Ou fez uma conta que não resulta em um número...")
        return
    }
    alert(`O resultado do seu cálculo é: ${conta}`)
}