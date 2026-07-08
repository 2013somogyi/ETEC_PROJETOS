// Hoteis
const hoteis = ["Juma Ópera", "Hotel Villa Amazônia", "Tropical Executive Hotel", "Novotel Manaus","Hotel Tambaú", "Verdegreen Hotel", "Nord Luxxor Cabo Branco", "Laguna Praia Hotel", "Hotel Deville Prime Cuiabá", "Delmond Hotel", "Gran Odara Hotel", "Mato Grosso Palace Hotel", "Novotel Campo Grande", "Deville Prime Campo Grande", "Indaiá Park Hotel", "Jandaia Hotel"]

function funHotel()
{
    const slDestino = document.getElementById('slDestino');
    const slHospedagem = document.getElementById('slHospedagem');

    if (slDestino.value === "1")
    {
        slHospedagem.innerHTML = '<option value="">Selecione um Hotel...</option>';

        const lgcHoteis = hoteis.slice(0, 4);

        lgcHoteis.forEach(hotel =>
        {
            const novaOpcao =new Option(hotel, hotel);
            slHospedagem.add(novaOpcao);
        })
    }
    else if (slDestino.value === "2")
    {
        slHospedagem.innerHTML = '<option value="">Selecione um Hotel...</option>';
        
        const lgcHoteis = hoteis.slice(4, 8);
        
        lgcHoteis.forEach(hotel =>
        {
            const novaOpcao =new Option(hotel, hotel);
            slHospedagem.add(novaOpcao);
        })
    }
    else if (slDestino.value === "3")
    {
        slHospedagem.innerHTML = '<option value="">Selecione um Hotel...</option>';

        const lgcHoteis = hoteis.slice(8, 12);
        
        lgcHoteis.forEach(hotel =>
        {
            const novaOpcao =new Option(hotel, hotel);
            slHospedagem.add(novaOpcao);
        })
    }
    else
    {
        slHospedagem.innerHTML = '<option value="">Selecione um Hotel...</option>';
        const lgcHoteis = hoteis.slice(12, 16);
        
        lgcHoteis.forEach(hotel =>
        {
            const novaOpcao =new Option(hotel, hotel);
            slHospedagem.add(novaOpcao);
        })
    }
    
}

function calcular()
{
    const dias = document.getElementById('txtDias').value;
    const txtOnibus = document.getElementById('txtOnibus');
    const txtAviao = document.getElementById('txtAviao');


    let preços = []

    for (let index = 100; index <= 16; index++)
    {
        let valorGerado = index + 200;
        
        preços.push(valorGerado);
    }


    for (let index = 0; index <hoteis.length; index++)
    {
        const indice = hoteis[index];
        
    }
}



