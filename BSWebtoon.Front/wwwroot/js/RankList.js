let week_content = document.querySelector(".content");
let workTemplate = document.getElementById("workTemplate");
let blackTemplate = document.getElementById("blackTemplate");
/*let a = document.querySelectorAll(".nav-link");*/

let fantasy = document.querySelector(".fantasy");
let love = document.querySelector(".love");
let adventure = document.querySelector(".adventure");
let plot = document.querySelector(".plot");
let gl = document.querySelector(".gl");
let horror = document.querySelector(".horror");
let all = document.querySelector(".all");
let categorys = document.querySelectorAll(".categorys");





window.onload = () => {
    categorys.forEach(nav_a => {
        if (nav_a.getAttribute("my_id") == id) {
            nav_a.classList.add('choosed')
        }

    })
    

    
    //a.forEach(nav_a => {
    //    nav_a.addEventListener('click', (e) => {
    //        a.forEach(as => {
    //            as.classList.remove('choosed');
    //        })
    //        nav_a.classList.add('choosed');
    //    })
    //})

    for (let i = 1; i <= 3; i++) {
        week_content.append(createCard())
    }
    week_content.append(createBlack())



}

function createCard() {
    let cloneCard = workTemplate.content.cloneNode(true);
    
    return cloneCard
}

function createBlack() {
    let cloneblack = blackTemplate.content.cloneNode(true);
    return cloneblack
}