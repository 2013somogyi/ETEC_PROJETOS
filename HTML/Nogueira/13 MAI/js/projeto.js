function atualizaRange()
{

    let range = document.getElementById("range");
    let retorno = document.getElementById("retorno");

    retorno.textContent = Number(range.value)
    .toLocaleString("pt-BR", {
        style: "currency",
        currency: "BRL"
    })

    // mascara para formatar em quilos, ou qualquer outra
    //retorno.textContent = range.value + " kg"
}

