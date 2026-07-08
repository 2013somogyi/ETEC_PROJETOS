const pessoas = [];
const campos = [
    document.getElementById("nome"),
    document.getElementById("dataNascimento"),
    document.getElementById("sexo"),
    document.getElementById("nacionalidade")
];
function addCadastro() {
    let formValido = true;

    //Validar

    for (let i = 0; i < campos.length; i++)
    {
        const campo = campos[i];
        const erro = campo.nextElementSibling;

        campo.classList.remove("erro-input")
        erro.classList.remove("mostrar-erro")

        if(campo.value === "")
        {
            campo.classList.add("erro-input")
            erro.classList.add("mostrar-erro")

            formValido = false
        }
    }

    if(formValido === false)
    {
        return;
    }

    //Adicionar no array

    pessoas.push({
        nome: campos[0].value,
        dataNascimento: campos[1].value,
        sexo: campos[2].value,
        nacionalidade: campos[3].value,
    });

    //Limpar campos
    for (let i = 0; i < campos.length; i++)
    {
        campos[i].value = "";
    }

    alert("Adicionado com sucesso")
}


function viewCadastro() {
    const tbody = document.getElementById("tbody")
    const mensagem = document.getElementById("mensagem")

    tbody.innerHTML = "";

    if (pessoas.length === 0)
    {
        mensagem.innerHTML = "";
        return;    
    }

    mensagem.innerHTML = "";

    //FOR com LENGTH

    for (let i = 0; i < pessoas.length; i++)
    {
            tbody.innerHTML += `
                
                <tr>
                    <td>${pessoas[i].nome}</td>
                    <td>${pessoas[i].dataNascimento}</td>
                    <td>${pessoas[i].sexo}</td>
                    <td>${pessoas[i].nacionalidade}</td>
                </tr>  
            
            `;
        
    }

}

function rmvCadastro() {
    
    pessoas.length = 0;
    document.getElementById("tbody").innerHTML = "";
    document.getElementById("mensagem").innerHTML = "Lista apagada";
}