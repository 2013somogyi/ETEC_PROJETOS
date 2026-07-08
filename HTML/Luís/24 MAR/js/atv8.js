const altura = parseFloat(prompt("Informe sua altura"))
const peso = parseFloat(prompt("Informe o seu peso"))

const imc = peso / (altura * altura)

if (imc<16.9){
    alert(`Seu IMC está em ${imc.toFixed(1)}, você está muito abaixo do peso!`)
}
else if (imc>=17 && imc<=18.9) {
    alert(`Seu IMC está em ${imc.toFixed(1)}, você está abaixo do peso!`)
}
else if (imc>=19 && imc<=26.9) {
    alert(`Seu IMC está em ${imc.toFixed(1)}, você está com o peso ideal!`)
}
else if (imc>=27 && imc<=31.9) {
    alert(`Seu IMC está em ${imc.toFixed(1)}, você está acima do peso!`)
}
else {
    alert(`Seu IMC está em ${imc.toFixed(1)}, você está em estado de obesidade!`)
}