////let mon = document.querySelector(".Monday .content")
////let teus = document.querySelector(".Tuesday .content")
////let workLongTemplate = document.getElementById("workLongTemplate")
////let workTemplate = document.getElementById("workTemplate")
////let a_Monday = document.querySelector(".a_Monday")
////let a_Tuesday = document.querySelector(".a_Tuesday")
////let Monday_title = document.querySelector(".Monday_title")
////let Tuesday_title = document.querySelector(".Tuesday_title")

////window.onload = () => {
////    mon.append(createCardlong());
////    for (let i = 1; i <= 30; i++) {
////        mon.append(createCard())
////    }

////    teus.append(createCardlong());
////    for (let i = 1; i <= 30; i++) {
////        teus.append(createCard())
////    }

////    let teus_long = document.querySelector(".Tuesday .work_long");
////    teus_long.setAttribute("style", "grid-column: 2/3;")
////}

////a_Monday.addEventListener("click", () => {
////    $('html, body').animate({ scrollTop: Monday_title.offset }, '500');

////})
////// a_Tuesday.addEventListener("click", () => {
//////     Tuesday_title.scrollIntoView(true, { behavior: "instant" });
////// })



////function createCardlong() {
////    let cloneCard = workLongTemplate.content.cloneNode(true);
////    cloneCard.querySelector("img").src = "https://tw-a.kakaopagecdn.com/P/C/214/bg/1x/f870dd2e-59a1-4324-bbbe-8419d26f0cf6.webp"
////    cloneCard.querySelector("source").src = "https://tw-a.kakaopagecdn.com/P/C/214/aclip/97caee36-c79a-4ec7-907d-f28cfd975c7c.webm"
////    cloneCard.querySelector(".title_long").innerText = "身為黑暗英雄的女兒";
////    return cloneCard
////}


////function createCard() {
////    let cloneCard = workTemplate.content.cloneNode(true);
////    cloneCard.querySelector("img").src = "https://tw-a.kakaopagecdn.com/P/C/148/bg/1x/f485a521-3410-48a7-a3de-793514f1237c.webp"
////    cloneCard.querySelector(".work_pic").src = "https://tw-a.kakaopagecdn.com/P/C/148/c2/2x/06e61fbe-0d6d-4145-9a9f-3723841ac527.webp"
////    cloneCard.querySelector("p").innerText = "無法親近的千金";

////    return cloneCard
////}


let mon = document.querySelector(".Monday .content")
let teus = document.querySelector(".Tuesday .content")
let workLongTemplate = document.getElementById("workLongTemplate")
let workTemplate = document.getElementById("workTemplate")
// let a_Monday = document.querySelector(".a_Monday")
// let a_Tuesday = document.querySelector(".a_Tuesday")
let Monday_title = document.querySelector(".Monday_title")
let Tuesday_title = document.querySelector(".Tuesday_title")
// let observer = new IntersectionObserver((entries) => {
//     entries.forEach((entry) => {
//         console.log(entry.target)
//         if (entry.isIntersecting && entry.target == Monday_title) {
//             a_Monday.classList.add("text-warning")
//             console.log(a_Monday)

//         }
//     })
// })
// observer.observe(Monday_title)
// observer.observe(Tuesday_title)

window.onload = () => {
    mon.append(createCardlong());
    for (let i = 1; i <= 15; i++) {
        mon.append(createCard())
    }

    teus.append(createCardlong());
    for (let i = 1; i <= 30; i++) {
        teus.append(createCard())
    }

    let teus_long = document.querySelector(".Tuesday .work_long");
    teus_long.setAttribute("style", "grid-column: 2/3;")

    // a_Monday.addEventListener("click", () => {
    //     Monday_title.scrollIntoView(true, { behavior: "auto" });

    // })
    // a_Tuesday.addEventListener("click", () => {
    //     Tuesday_title.scrollIntoView(true, { behavior: "auto" });
    // })



}




function createCardlong() {
    let cloneCard = workLongTemplate.content.cloneNode(true);
    cloneCard.querySelector("img").src = "https://tw-a.kakaopagecdn.com/P/C/214/bg/1x/f870dd2e-59a1-4324-bbbe-8419d26f0cf6.webp"
    cloneCard.querySelector("source").src = "https://tw-a.kakaopagecdn.com/P/C/214/aclip/97caee36-c79a-4ec7-907d-f28cfd975c7c.webm"
    cloneCard.querySelector(".title_long").innerText = "身為黑暗英雄的女兒";
    return cloneCard
}


function createCard() {
    let cloneCard = workTemplate.content.cloneNode(true);
    cloneCard.querySelector("img").src = "https://tw-a.kakaopagecdn.com/P/C/148/bg/1x/f485a521-3410-48a7-a3de-793514f1237c.webp"
    cloneCard.querySelector(".work_pic").src = "https://tw-a.kakaopagecdn.com/P/C/148/c2/2x/06e61fbe-0d6d-4145-9a9f-3723841ac527.webp"
    cloneCard.querySelector("p").innerText = "無法親近的千金";

    return cloneCard
}
