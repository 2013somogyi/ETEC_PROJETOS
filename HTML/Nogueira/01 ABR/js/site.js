cxNomeSite = prompt("Escreva o nome do seu site")
const nomeSite = document.getElementById('titulo')
if (cxNomeSite == "") {
    nomeSite.textContent = "Título"
}
else{
    nomeSite.textContent = (cxNomeSite)
}
B