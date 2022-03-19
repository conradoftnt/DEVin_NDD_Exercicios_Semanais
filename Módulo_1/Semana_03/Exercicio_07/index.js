function ex07() {
    let nascimento = Number(prompt("Em que ano você nasceu?"))
    let ano = Number(prompt("Em que ano estamos?"))
    alert(`Sua idade é ${ano - nascimento} ou ${ano - nascimento - 1}`)
}