// const idade = parseInt(prompt("Informe sua idade"));
// const nacionalidade = prompt("Informe sua nacionalidade")
    
// if (idade >=18 && idade < 65 && nacionalidade == "Brasileiro") {    
//         alert("Seu voto é obrigatório")
    
//     } else if(idade  >= 16 && idade <18 || idade >=65) {
//         alert("Você vota se quiser")
    
//     } else {
//         alert("Você não pode votar")
//     }
    

const filosofia = parseInt(prompt("Qual foi sua nota de Filosofia?"));
const matematica = parseInt(prompt("Qual foi sua nota de Matemática?"));
const geografia = parseInt(prompt("Qual foi sua nota de Geografia?"));
const programação = parseInt(prompt("Qual foi sua nota de Programação?"));

const média = (filosofia + matematica + geografia + programação) / 4;

if (média >= 7) {
    alert(`Você fechou com ${média}, você foi aprovado`)
} else if (média < 7 || média >= 5) {
    alert(`Você fechou com ${média}, você está de recuperação`)
} else {
    alert(`Você fechou com ${média}, você foi reprovado`)
}

