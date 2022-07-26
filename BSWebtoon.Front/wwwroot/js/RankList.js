let week_content = document.querySelector(".content")
let workTemplate = document.getElementById("workTemplate")
let blackTemplate = document.getElementById("blackTemplate")
let a = document.querySelectorAll(".nav-link");




window.onload = () => {
    
    a.forEach(nav_a => {
        nav_a.addEventListener('click', () => {
            a.forEach(as => {
                as.classList.remove('choosed');
            })
            nav_a.classList.add('choosed');
        })
    })

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