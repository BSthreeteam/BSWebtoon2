let date_week = new Date();
let nav_a_week = document.querySelector(".nav_a_week")
let mon = document.querySelector(".nav_Monday")
let tues = document.querySelector(".nav_Tuesday")
let wednes = document.querySelector(".nav_Wednesday")
let thurs = document.querySelector(".nav_Thursday")
let fri = document.querySelector(".nav_Friday")
let satur = document.querySelector(".nav_Saturday ")
let sun = document.querySelector(".nav_Sunday")
let weeklyArray = [sun, mon, tues, wednes, thurs, fri, satur];





nav_a_week.addEventListener("click", () => {
    weeklyArray.forEach((day, index) => {
        if (date_week.getDay() == index) { day.click() }
    })

})
