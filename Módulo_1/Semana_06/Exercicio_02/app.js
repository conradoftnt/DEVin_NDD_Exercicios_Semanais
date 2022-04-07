const calcular = () => {
    const num1 = Number(document.getElementById("num1").value);
    const num2 = Number(document.getElementById("num2").value);
    const operador = document.getElementById("operador").value;
    let resultado = 0;
    switch (operador) {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "/":
            resultado = num1 / num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
    }
    const mostraResultado = document.createElement('p');
    mostraResultado.innerText = resultado;
    document.body.appendChild(mostraResultado);
}