"use strict";

const screen = document.getElementById("screen");
const xmlns = "http://www.w3.org/2000/svg";

// 1. Configuração de Cores e Gradientes
const defs = document.createElementNS(xmlns, "defs");
defs.innerHTML = `
    <linearGradient id="dragonGradient" x1="0%" y1="0%" x2="100%" y2="0%">
        <stop offset="0%" stop-color="#00ffcc" />
        <stop offset="100%" stop-color="#004d40" />
    </linearGradient>
`;
screen.appendChild(defs);

// 2. Elementos do Dragão
// Criamos um PATH para o corpo e um CIRCLE para a cabeça
const bodyPath = document.createElementNS(xmlns, "path");
bodyPath.setAttribute("id", "dragon-body");
screen.appendChild(bodyPath);

const head = document.createElementNS(xmlns, "circle");
head.setAttribute("id", "dragon-head");
head.setAttribute("r", "15");
screen.appendChild(head);

// 3. Lógica de Pontos
const points = [];
const numPoints = 25; // Quantidade de "ossos" do dragão
const mouse = { x: window.innerWidth / 2, y: window.innerHeight / 2 };

for (let i = 0; i < numPoints; i++) {
    points.push({ x: mouse.x, y: mouse.y });
}

window.addEventListener("pointermove", (e) => {
    mouse.x = e.clientX;
    mouse.y = e.clientY;
});

function resize() {
    screen.setAttribute("viewBox", `0 0 ${window.innerWidth} ${window.innerHeight}`);
}
window.addEventListener("resize", resize);
resize();

// 4. Animação Suave
function animate() {
    // A cabeça segue o mouse
    points[0].x += (mouse.x - points[0].x) * 0.3;
    points[0].y += (mouse.y - points[0].y) * 0.3;

    // Cada ponto seguinte segue o anterior com atraso
    for (let i = 1; i < numPoints; i++) {
        const p = points[i];
        const prev = points[i - 1];
        p.x += (prev.x - p.x) * 0.4;
        p.y += (prev.y - p.y) * 0.4;
    }

    // Gerar a "string" do comando D do Path (Curva de Bezier)
    let d = `M ${points[0].x} ${points[0].y}`;
    for (let i = 1; i < numPoints; i++) {
        // Criamos uma curva suave entre os pontos
        const xc = (points[i].x + points[i - 1].x) / 2;
        const yc = (points[i].y + points[i - 1].y) / 2;
        d += ` Q ${points[i - 1].x} ${points[i - 1].y}, ${xc} ${yc}`;
    }

    bodyPath.setAttribute("d", d);
    
    // Posiciona a cabeça
    head.setAttribute("cx", points[0].x);
    head.setAttribute("cy", points[0].y);

    requestAnimationFrame(animate);
}

animate();