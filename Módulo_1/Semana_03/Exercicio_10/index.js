function ex10(){
    let valorInicial = Number(prompt("Digite o valor inicial da P.A:"));
    let progressao = Number(prompt("Digite o valor da prograssão da P.A:"));
    if(isNaN(valorInicial) || isNaN(progressao)){
        alert("Você inseriu um valor que não é um número!")
        return;
    }
    let resultado = `${valorInicial} ${valorInicial + progressao} ${valorInicial + (progressao * 2)} ${valorInicial + (progressao * 3)} ${valorInicial + (progressao * 4)} ${valorInicial + (progressao * 5)} ${valorInicial + (progressao * 6)} ${valorInicial + (progressao * 7)} ${valorInicial + (progressao * 8)} ${valorInicial + (progressao * 9)}`
    alert(resultado);
}