// Import thư viện Teachable Machine
const URL = "https://teachablemachine.withgoogle.com/models/YOUR_MODEL/";
let model, webcam, ctx, labelContainer, maxPredictions;
let robotX = 200;
let isHandOpen = false;
let objects = [];
let robotImg = new Image();
robotImg.src = "robot.png";
let objectImg = new Image();
objectImg.src = "object.png";

// Khởi tạo Teachable Machine
async function init() {
    const modelURL = URL + "model.json";
    const metadataURL = URL + "metadata.json";
    model = await tmImage.load(modelURL, metadataURL);
    maxPredictions = model.getTotalClasses();
    webcam = new tmImage.Webcam(200, 200, true);
    await webcam.setup();
    await webcam.play();
    window.requestAnimationFrame(loop);
    document.getElementById("webcam-container").appendChild(webcam.canvas);
}

async function loop() {
    webcam.update();
    await predict();
    updateGame();
    drawGame();
    window.requestAnimationFrame(loop);
}

async function predict() {
    const prediction = await model.predict(webcam.canvas);
    if (prediction[0].probability > 0.8) robotX -= 5;  // Tay trái
    if (prediction[1].probability > 0.8) robotX += 5;  // Tay phải
    isHandOpen = prediction[2].probability > 0.8;  // Xòe tay
}

function updateGame() {
    if (Math.random() < 0.02) {
        objects.push({ x: Math.random() * 400, y: 0, caught: false });
    }
    objects.forEach(obj => {
        obj.y += 3;
        if (isHandOpen && Math.abs(obj.x - robotX) < 30 && obj.y > 350) {
            obj.caught = true;
        }
    });
    objects = objects.filter(obj => obj.y < 400 && !obj.caught);
}

function drawGame() {
    let canvas = document.getElementById("gameCanvas");
    let ctx = canvas.getContext("2d");
    ctx.clearRect(0, 0, 400, 400);
    ctx.drawImage(robotImg, robotX, 350, 50, 50);
    objects.forEach(obj => ctx.drawImage(objectImg, obj.x, obj.y, 20, 20));
}

document.addEventListener("DOMContentLoaded", () => {
    init();
});
