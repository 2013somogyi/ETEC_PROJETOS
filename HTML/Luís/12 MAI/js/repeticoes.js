// for (let index = 0; index <= 2; index++)
// {
//     const nome  = prompt("Digite seu nome: ");
//     alert(nome);
// }

// let i = 0
// while (i <= 2)
// {   
//     i++;
// }

// total = prompt("Digite o número de vezes que deseja repetir: ");
// i = 0;

// let continuar = 2;

// do
// {
//     nome  = prompt("Digite seu nome: ");
//     alert(`Seu nome é ${nome}`);
    
//     continuar = prompt("Deseja continuar? Digite 1 para sim ou 2 para não: ");

// } while (continuar != 2);


let i = prompt("Digite o número de vezes que deseja repetir: ");
cont = 1;
do
{
    alert(`Essa é a ${cont}° vez que está repetindo!`)
    cont++

} while (i >= cont)