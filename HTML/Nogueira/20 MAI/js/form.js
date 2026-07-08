function limpa_formulário_cep()
{
        //Limpa valores do formulário de cep.
        document.getElementById('rua').value=("");
        document.getElementById('bairro').value=("");
        document.getElementById('cidade').value=("");
        document.getElementById('uf').value=("");
}

function meu_callback(conteudo)
{
    if (!("erro" in conteudo)) {
        //Atualiza os campos com os valores.
        document.getElementById('rua').value=(conteudo.logradouro);
        document.getElementById('bairro').value=(conteudo.bairro);
        document.getElementById('cidade').value=(conteudo.localidade);
        document.getElementById('uf').value=(conteudo.uf);
    } //end if.
    else {
        //CEP não Encontrado.
        limpa_formulário_cep();
        alert("CEP não encontrado.");
    }
}
    
function pesquisacep(valor)
{

    //Nova variável "cep" somente com dígitos.
    var cep = valor.replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (cep != "") {

        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;

        //Valida o formato do CEP.
        if(validacep.test(cep)) {

            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('rua').value="...";
            document.getElementById('bairro').value="...";
            document.getElementById('cidade').value="...";
            document.getElementById('uf').value="...";


            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = 'https://viacep.com.br/ws/'+ cep + '/json/?callback=meu_callback';

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);

        } //end if.
        else {
            //cep é inválido.
            limpa_formulário_cep();
            alert("Formato de CEP inválido.");
        }
    } //end if.
    else {
        //cep sem valor, limpa formulário.
        limpa_formulário_cep();
    }
};

function formataCPF(campo)
{
    
    let cpf = campo.value.replace(/\D/g, "");

    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2"); 
    
    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2"); 
    
    cpf = cpf.replace(/(\d{3})(\d{1,2})$/, "$1-$2");

    campo.value = cpf;
}

function formataTelefone(campo)
{
    let tel = campo.value.replace(/\D/g, "");

    tel = tel.replace(/^(\d{2})(\d)/g, "($1) $2");

    tel = tel.replace(/(\d)(\d{4})$/, "$1-$2");

    campo.value = tel;

}

function formataCEP(campo)
{
    let cep = campo.value.replace(/\D/g, "");

    cep = cep.replace(/(\d{5})(\d)/, "$1-$2");

    campo.value = cep;

}
function formataRG(campo)
{
    let rg = campo.value.replace(/\D/g, "");

    rg = rg.replace(/(\d{2})(\d)/, "$1.$2");

    rg = rg.replace(/(\d{3})(\d)/, "$1.$2");

    rg = rg.replace(/(\d{3})(\d{1,2})$/, "$1-$2");

    campo.value = rg;

}

function formataNome(campo)
{
    campo.value = campo.value.replace(/[^a-zA-ZÀ-ÿ\s]/g, "");
    campo.value = campo.value.replace(/\d/g, "")
}


//VALIDAÇÃO
const pessoas = [];
const campos = [
    document.getElementById("nome"),
    document.getElementById("dataNascimento"),
    document.getElementById("sexo"),
    document.getElementById("cpf"),
    document.getElementById("rg"),
    document.getElementById("estadoCivil"),
    document.getElementById("telefone"),
    document.getElementById("email"),
    document.getElementById("cep"),
    document.getElementById("rua"),
    document.getElementById("numero"),
    document.getElementById("bairro"),
    document.getElementById("cidade"),
    document.getElementById("uf"),
    document.getElementById("numeroSUS"),
    document.getElementById("convenioMedico"),
    document.getElementById("numeroCarteirinha"),
    document.getElementById("medicoResponsavel"),
];
function addCadastro() {
    let formValido = true;

    //Validar

    for (let i = 0; i < campos.length; i++)
    {
        const campo = campos[i];
        const erro = campo.nextElementSibling;

        campo.classList.remove("erro-input")
        if (erro) {
            erro.classList.remove("mostrar-erro")
        }

        if(campo.value.trim() === "")
        {
            campo.classList.add("erro-input")
            if (erro) {
                erro.classList.add("mostrar-erro")
            }

            formValido = false
        }
    }

    if(formValido === false)
    {
        return;
    }

    //Adicionar no array

    pessoas.push({
        nome: document.getElementById("nome").value,
        dataNascimento: document.getElementById("dataNascimento").value,
        sexo: document.getElementById("sexo").value,
        cpf: document.getElementById("cpf").value,
        rg: document.getElementById("rg").value,
        estadoCivil: document.getElementById("estadoCivil").value,
        telefone: document.getElementById("telefone").value,
        email: document.getElementById("email").value,
        cep: document.getElementById("cep").value,
        rua: document.getElementById("rua").value,
        numero: document.getElementById("numero").value,
        bairro: document.getElementById("bairro").value,
        cidade: document.getElementById("cidade").value,
        uf: document.getElementById("uf").value,
        numeroSUS: document.getElementById("numeroSUS").value,
        convenioMedico: document.getElementById("convenioMedico").value,
        numeroCarteirinha: document.getElementById("numeroCarteirinha").value,
        medicoResponsavel: document.getElementById("medicoResponsavel").value,
    });

    //Limpar campos
    for (let i = 0; i < campos.length; i++)
    {
        campos[i].value = "";
    }

    alert("Adicionado com sucesso")
}