let impares = 0;
let contador = 0;

while(impares < 10){
    contador++
    if((contador%2) !== 0){
        impares++
    }
    console.log(`Contador: ${contador}`)
    console.log(`Impares: ${impares}`)
}