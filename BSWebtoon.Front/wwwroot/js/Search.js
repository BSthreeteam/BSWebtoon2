let week_content = document.querySelector(".content")
let workTemplate = document.getElementById("workTemplate")
let blackTemplate = document.getElementById("blackTemplate")

window.onload = () => {


    for (let i = 1; i <= 15; i++) {
        week_content.append(createCard())
    }
    //week_content.append(createBlack())
}

function createCard() {
    let cloneCard = workTemplate.content.cloneNode(true);
    //cloneCard.querySelector("img").src = "https://tw-a.kakaopagecdn.com/P/C/148/bg/1x/f485a521-3410-48a7-a3de-793514f1237c.webp"
    //cloneCard.querySelector(".work_pic").src = "https://tw-a.kakaopagecdn.com/P/C/148/c2/2x/06e61fbe-0d6d-4145-9a9f-3723841ac527.webp"
    //cloneCard.querySelector(".title_img").src = "https://tw-a.kakaopagecdn.com/P/C/205/t2/2x/8848e3ef-a605-412f-9d37-d544e22af515.png";

    return cloneCard
}

//function createBlack() {
//    let cloneblack = blackTemplate.content.cloneNode(true);
//    return cloneblack
//}