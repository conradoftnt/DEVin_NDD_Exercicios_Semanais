function conta(numA, operacao, numB){
    switch(operacao){
        case "soma":
        case "+":
            console.log(numA + numB)
            return
        case "subtração":
        case "-":
            console.log(numA - numB)
            return
        case "divisão":
        case "/":
            console.log(numA / numB)
            return
        case "multiplicação":
        case "*":
            console.log(numA * numB)
            return
        default:
            console.log("Você não inseriu um operadoração disponível!")
            return
    }
}

let num1 = 5;
let num2 = 4;

conta(num1,"+",num2);
conta(num1,"-",num2);
conta(num1,"/",num2);
conta(num1,"*",num2);
conta(num1,"@",num2);