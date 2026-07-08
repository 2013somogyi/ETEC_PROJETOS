const inputSalario = document.getElementById("salario");
const inputBonus = document.getElementById("bonus");
const table = document.getElementById("table");
const mensagem = document.getElementById("mensagem");
const tbody = document.getElementById("tbody");

//TAXAS

function calcular()
{
    tbody.innerHTML = "";

    //VARIAVEIS
    const salario = Number(inputSalario.value);
    const bonus = Number(inputBonus.value);
    const taxas = [0.075, 0.09, 0.12, 0.14, 0.20];
    const parcelas = [0, 24.32, 111.40, 198.49, 213.27];
    let resultado = salario + bonus;

    //SPAN 
    mensagem.classList.remove("hide");
    table.classList.remove("hide");
   
    //TABELA
    if (resultado >= 0 && resultado <=1621)
    {
        resultado = (resultado * taxas[0]) - parcelas[0];
        tbody.innerHTML += `
                
                <tr>
                    <td>R$00,0</td>
                    <td>R$1621,00</td>
                    <td>7,5%</td>
                    <td> - </td>
                </tr>  
                
                `;
        mensagem.textContent = `Sua contibuição será de: R$ ${resultado.toFixed(2)}`;

    }
    else if (resultado >= 1621.01 && resultado <=2902.84)
    {
        resultado = (resultado * taxas[1]) - parcelas[1];
        tbody.innerHTML += `
                
                <tr>
                    <td>R$1621,01</td>
                    <td>R$2902,84</td>
                    <td>9,0%</td>
                    <td> R$24,32 </td>
                </tr>  
                
                `;
        mensagem.textContent = `Sua contibuição será de: R$ ${resultado.toFixed(2)}`;

    }

    else if (resultado >= 2902.85 && resultado <=4354.27)
    {
        resultado = (resultado * taxas[2]) - parcelas[2];
        tbody.innerHTML += `
                
                <tr>
                    <td>R$2902,85</td>
                    <td>R$4354,27</td>
                    <td>12,0%</td>
                    <td> R$111,40 </td>
                </tr>  
                
                `;
        mensagem.textContent = `Sua contibuição será de: R$ ${resultado.toFixed(2)}`;

    }

    else if (resultado >= 4354.28 && resultado <=8475.55)
    {
        resultado = (resultado * taxas[3]) - parcelas[3];
        tbody.innerHTML += `
                
                <tr>
                    <td>R$4354.28</td>
                    <td>R$8475.55</td>
                    <td>14,0%</td>
                    <td> R$198,49 </td>
                </tr>  
                
                `;
        mensagem.textContent = `Sua contibuição será de: R$ ${resultado.toFixed(2)}`;

    }
    
    else if (resultado >= 8475.56)
    {
        resultado = 980.87 + bonus;
        tbody.innerHTML += `
                
                <tr>
                    <td>R$8475,56</td>
                    <td> - </td>
                    <td>20,0%</td>
                    <td> R$213,27 </td>
                </tr>  
                
                `;
        mensagem.textContent = `Sua contibuição será de: R$ ${resultado.toFixed(2)}`;

    }

    else
    {
        alert("Insira um valor válido!");
    }
    
}