let btn_all = document.querySelector(".all");
let btn_fantasy = document.querySelector(".fantasy");
let btn_fantasy_love = document.querySelector(".fantasy_love");
let btn_love = document.querySelector(".love");
let btn_plot = document.querySelector(".plot");
let btn_BL_GL = document.querySelector(".BL_GL");
let btn_Suspenseful_horror = document.querySelector(".Suspenseful_horror");
let bestseller = document.querySelector("#bestseller");
let output = document.querySelector(".output");
let cloneCard = bestseller.content.cloneNode(true);
window.onload = function () {
    btn_all.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_fantasy.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_fantasy_love.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_love.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_plot.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_BL_GL.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
    btn_Suspenseful_horror.addEventListener("click", () => {
        output.innerHTML = "";
        output.appendChild(cloneCard);
    })
}