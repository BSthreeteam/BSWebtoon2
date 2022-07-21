let mon_con = document.querySelector(".Monday .content")
let tues_con = document.querySelector(".Tuesday .content")
let wednes_con = document.querySelector(".Wednesday .content")
let thurs_con = document.querySelector(".Thursday .content")
let fri_con = document.querySelector(".Friday .content")
let satur_con = document.querySelector(".Saturday .content")
let sun_con = document.querySelector(".Sunday .content")
let blackTemplate = document.getElementById("blackTemplate")

let date_week = new Date();

let mon = document.querySelector(".nav_Monday")
let tues = document.querySelector(".nav_Tuesday")
let wednes = document.querySelector(".nav_Wednesday")
let thurs = document.querySelector(".nav_Thursday")
let fri = document.querySelector(".nav_Friday")
let satur = document.querySelector(".nav_Saturday ")
let sun = document.querySelector(".nav_Sunday")
let weeklyArray = [sun, mon, tues, wednes, thurs, fri, satur];










window.onload = () => {


    mon_con.append(createBlack())

    tues_con.append(createBlack())
    wednes_con.append(createBlack())
    thurs_con.append(createBlack())
    fri_con.append(createBlack())
    satur_con.append(createBlack())
    sun_con.append(createBlack())


    let teus_long = document.querySelector(".Tuesday .work_long");
    teus_long.setAttribute("style", "grid-column: 3/4;")

    let wednes_long = document.querySelector(".Wednesday .work_long");
    wednes_long.setAttribute("style", "grid-column: 2/3;")

    let fri_long = document.querySelector(".Friday .work_long");
    fri_long.setAttribute("style", "grid-column: 3/4;")

    let satur_long = document.querySelector(".Saturday .work_long");
    satur_long.setAttribute("style", "grid-column: 2/3;")



        weeklyArray.forEach((day, index) => {

            if (date_week.getDay() == index) {
                day.click()
            }


        })




}



function createBlack() {
    let cloneblack = blackTemplate.content.cloneNode(true);
    return cloneblack
}
