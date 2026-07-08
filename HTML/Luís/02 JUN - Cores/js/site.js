
function changeColor()
{
    //Cores
    let red = document.getElementById('rg-r').value;
    let green = document.getElementById('rg-g').value;
    let blue = document.getElementById('rg-b').value;

    //TextBox
    const txtR = document.getElementById('txt-r');
    const txtG = document.getElementById('txt-g');
    const txtB = document.getElementById('txt-b'); 

    //Div
    const divColor = document.getElementById('divColor');
        
    divColor.style.backgroundColor = `rgb(${red}, ${green}, ${blue})`;

    //TextBoxes com valores
    txtR.value = red;
    txtG.value = green;
    txtB.value = blue;
}

function changeTxt()
{
    //Cores
    let red = document.getElementById('rg-rtxt').value;
    let green = document.getElementById('rg-gtxt').value;
    let blue = document.getElementById('rg-btxt').value;

    //TextBox
    const txtRtxt = document.getElementById('txt-rtxt');
    const txtGtxt = document.getElementById('txt-gtxt');
    const txtBtxt = document.getElementById('txt-btxt'); 

    //textoDiv
    const textoDiv = document.getElementById('textoDiv');
        
    textoDiv.style.color = `rgb(${red}, ${green}, ${blue})`;

    //TextBoxes com valores
    txtRtxt.value = red;
    txtGtxt.value = green;
    txtBtxt.value = blue;
}