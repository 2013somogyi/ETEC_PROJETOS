const filosofia = parseFloat(prompt("Qual foi sua nota em Filosofia?"))
const matemática = parseFloat(prompt("Qual foi sua nota em Matemática?"))
const artes = parseFloat(prompt("Qual foi sua nota em Artes?"))
const ciencias = parseFloat(prompt("Qual foi sua nota em Ciências?"))

const média = (filosofia + matemática + artes + ciencias) / 4

if(média>=7 && média<=10){
    alert("Você foi aprovado")
}
else if (média>=5 && média <=6.9){
    alert("Você está de recuperação")
}
else{
    alert("Você foi reprovado")
}
    