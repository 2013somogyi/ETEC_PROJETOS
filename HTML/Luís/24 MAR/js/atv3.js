const popchina = parseInt(prompt("Qual é a população da China?"))
const popbrasil = parseInt(prompt("Qual é a população do Brasil?"))

if (popchina > popbrasil) {
    alert("A China é mais populosa!")
} else if ( popchina < popbrasil) {
    alert ("O Brasil é mais populoso. Incrìvel!")
} else{
    alert("Ambos possuem a mesma quantidade de pessoas!")
}

