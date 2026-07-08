const valor1 = parseFloat(prompt("Escreva o primeiro número"))
const valor2 = parseFloat(prompt("Escreva o segundo número"))
const valor3 = parseFloat(prompt("Escreva o terceiro número"))

if (valor1>valor2 && valor1>valor3) {
    alert (`O número ${valor1} é maior que os outros (${valor2},${valor3})`)
}
else if(valor2>valor1 && valor2>valor3) {
   alert (`O número ${valor2} é maior que os outros (${valor1},${valor3})`) 
}
else if (valor1 == valor2 && valor1 == valor3 && valor2 == valor3){
    alert("Você digitou números iguais")
}
else{
    alert (`O número ${valor3} é maior que os outros (${valor1},${valor2})`) 
}