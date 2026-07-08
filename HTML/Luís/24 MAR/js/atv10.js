const lado1 = parseFloat(prompt("Informe o tamanho do primeiro lado"))
const lado2 = parseFloat(prompt("Informe o tamanho do segundo lado"))
const lado3 = parseFloat(prompt("Informe o tamanho do terceiro lado"))

if(lado1!=lado2 && lado1!=lado3 && lado2!=lado3) {
    alert("Esse é um triângulo Escaleno!")
}
else if(lado1==lado2 && lado1==lado3 && lado2==lado3) {
    alert("Esse é um triângulo Equilátero!")
}
else{
    alert("Esse é um triângulo Isósceles!")
}