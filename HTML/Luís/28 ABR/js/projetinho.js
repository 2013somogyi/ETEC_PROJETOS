const taskList = document.getElementById('taskList');
let contador = 0;

function add_item()
{
    const inputText = document.getElementById('inputText');
    if (inputText.value == "")
    {
        alert("Primeiro insira um texto")
    }
    else
    {
        // Cria um elemento no HTML
        const li = document.createElement("li");

        // innerHTML Adiciona conteúdo dentro de um elemento HTML
        li.innerHTML = `
            <span>${inputText.value}</span>
            <button class="btn btn-danger btn-sm remover" data-id="${contador}">✖</button>
        `
        
        li.classList.add('list-group-item');

        taskList.appendChild(li);

        inputText.value = "";
        contador += 1;
    }
}

function clean(event)
{
    if (event.target.classList.contains("remover") || event.target.textContent == "✖")
    {   // event.target pega o elemento que disparou a ação
        event.target.parentElement.remove();
        // event.target.remove(); Apaga o botão
    }
    
    if (event.target.tagName == "SPAN") 
    {  //tagname pega o nome da tag

       event.target.classList.toggle("concluido")
       // toogle verifica se já possui a classe, se tiver ele remove, se não tiver ele adiciona, facilita o código
    }
    
    

    // alert('Item removido com sucesso')
}