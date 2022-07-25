let week_content = document.querySelector(".content")
let workTemplate = document.getElementById("workTemplate")
let blackTemplate = document.getElementById("blackTemplate")
//let all = document.querySelector(".all")
//let fantasy = document.querySelector(".fantasy")
//let love = document.querySelector(".love")
//let adventure = document.querySelector(".adventure")
//let plot = document.querySelector(".plot")
//let gl = document.querySelector(".gl")
//let horror = document.querySelector(".horror")
let btn = document.querySelectorAll(".btn");
let li = document.querySelectorAll("")




window.onload = () => {

    for (let i = 1; i <= 99; i++) {
        week_content.append(createCard())
    }
    week_content.append(createBlack())

    btn.addEventListener("click", () => {

    })

}

function createCard() {
    let cloneCard = workTemplate.content.cloneNode(true);
    
    return cloneCard
}

function createBlack() {
    let cloneblack = blackTemplate.content.cloneNode(true);
    return cloneblack
}