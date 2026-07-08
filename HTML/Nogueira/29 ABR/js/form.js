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

function formataNome(campo)
{
    campo.value = campo.value.replace(/[^a-zA-ZÀ-ÿ\s]/g, "");
    campo.value = campo.value.replace(/\d/g, "")
}