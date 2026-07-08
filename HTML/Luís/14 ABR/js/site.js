

//---------------------------------------------------------------------------//

function mudatxt() {
const titulo = document.getElementById("titulo");
const nome = document.getElementById("campoNome").value;

titulo.textContent = (nome) 
}
function mudaCor() {
    /*
    const corTitulo = document.querySelector("h1");
    corTitulo.style.color = 'random'
    */
   const r = Math.floor(Math.random() * 256);
   const g = Math.floor(Math.random() * 256);
   const b = Math.floor(Math.random() * 256);

   document.querySelector("h1").style.color = `rgb(${r}, ${g}, ${b})`
}
function mudaFundo() {
    /*
    const corFundo = document.querySelector("body");
    corFundo.style.backgroundColor = 'orange'
    */
   const r = Math.floor(Math.random() * 256);
   const g = Math.floor(Math.random() * 256);
   const b = Math.floor(Math.random() * 256);

   document.body.style.backgroundColor = `rgb(${r}, ${g}, ${b})`
}

//---------------------------------------------------------------------------//


function temaEscuro() {
    let item1 = document.querySelector("h1");
    let item2 = document.querySelector("button");
    let item3 = document.body;
    let item4 = document.querySelector("p")


    item1.classList.add('escuroEscrita');
    item2.classList.add('escuroBotoes');
    item3.classList.add("escuroFundo");
    item4.classList.add("escuroEscrita");
}

function temaClaro() {
    let item1 = document.querySelector("h1");
    let item2 = document.querySelector("button");
    let item3 = document.body;
    let item4 = document.querySelector("p")

    item1.classList.remove('escuroEscrita');
    item2.classList.remove('escuroBotoes');
    item3.classList.remove("escuroFundo");
    item4.classList.remove("escuroEscrita");
}


//---------------------------------------------------------------------------//


//09 ABR 2026

/*
function mudatxt(){
    alert("Função acionada")
}
*/


//---------------------------------------------------------------------------//



/*
const botao = document.getElementById('bt')
let meuTitulo = document.getElementById('titulo')

botao.addEventListener('click', function() {
    meuTitulo.textContent = 'Olha o outro titulo'
})

const input = document.getElementById('campoNome')
console.log(input)
*/


//--------------------------------------------------------------------------//


/*
//getElementByld() é o método que busca o elemento no documento HTML

//Pega os dados do ELEMENTO em si
const paragrafo = document.getElementById('prg1')
const titulo = document.getElementById('ttl1')

//Pega os dados do VALOR do elemento, ou as informações inseridas
const nome = document.getElementById('nm1')
*/