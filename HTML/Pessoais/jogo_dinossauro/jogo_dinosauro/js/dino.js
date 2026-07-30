const dino = document.getElementById("dino");
const cactus= document.getElementById("cactus");
const scoreElement = document.getElementById("score");
const gameOverElement = document.getElementById("gameOver");

let isJumping = false;
let isGameOver = false;
let score = 0;
let scoreInterval;
let checkCollisionInterval;

function startGame() {
    isGameOver = false;
    score = 0;
    scoreElement.innerText = "Pontos: " + score;
    gameOverElement.style.display = "none";

    cactus.classList.remove("cactus-move");
    void cactus.offsetWidth;
    cactus.classList.add("cactus-move");

    scoreInterval = setInterval(() => {
        score++;
        scoreElement.innerText = "Pontos: " + score;
    }, 100);

    checkCollisionInterval = setInterval(checkCollision, 10);
}

function jump() {
    if (isJumping || isGameOver)return;

    isJumping = true;
    dino.classList.add("jump");

    setTimeout(() => {
        dino.classList.remove("jump");
        isJumping = false;
    }, 500);
}

function checkCollision() {
    const dinoBottom = parseInt(
        window.getComputedStyle(dino).getPropertyValue("bottom")
    );

    const cactusLeft = parseInt(
        window.getComputedStyle(cactus).getPropertyValue("left")
    );

    if (cactusLeft > 50 && cactusLeft < 90 && dinoBottom < 40) {
        handleGameOver(); // Chama a função ao colidir!
    }
}

function handleGameOver() {
    isGameOver = true;

    cactus.classList.remove("cactus-move");
    clearInterval(scoreInterval);
    clearInterval(checkCollisionInterval);

    gameOverElement.style.display = "block";
}

document.addEventListener("keydown", (event) => {
    if(event.code ==="Space") {
        if(isGameOver) {
            startGame();
        } else {
            jump();
        }
    }
});

startGame();