let mon = document.querySelector(".Monday .content")
let teus = document.querySelector(".Tuesday .content")
let wednes = document.querySelector(".Wednesday .content")
let thurs = document.querySelector(".Thursday .content")
let fri = document.querySelector(".Friday .content")
let satur = document.querySelector(".Saturday .content")
let sun = document.querySelector(".Sunday .content")
let blackTemplate = document.getElementById("blackTemplate")





window.onload = () => {


    mon.append(createBlack())

    teus.append(createBlack())
    wednes.append(createBlack())
    thurs.append(createBlack())
    fri.append(createBlack())
    satur.append(createBlack())
    sun.append(createBlack())


    let teus_long = document.querySelector(".Tuesday .work_long");
    teus_long.setAttribute("style", "grid-column: 3/4;")

    let wednes_long = document.querySelector(".Wednesday .work_long");
    wednes_long.setAttribute("style", "grid-column: 2/3;")

    let fri_long = document.querySelector(".Friday .work_long");
    fri_long.setAttribute("style", "grid-column: 3/4;")

    let satur_long = document.querySelector(".Saturday .work_long");
    satur_long.setAttribute("style", "grid-column: 2/3;")

}



function createBlack() {
    let cloneblack = blackTemplate.content.cloneNode(true);
    return cloneblack
}
