window.onload = function () {
    let mainPic = document.querySelectorAll('.recommend-pic')
    let bgPic = document.querySelectorAll('.recommend-pic-bg')
    //mainPic.style.transform = `translateX(${window.scrollY / 100}%)`

    window.addEventListener('mousewheel', (e) => {
        if (e.wheelDelta > 0) {
            // alert("滑輪向上滾動");
            //console.log(window.scrollY)
            //console.log("滑輪向上滾動")
            mainPic.forEach((e) => {
                e.style.transform = `translateX(${window.scrollY / 1100}%)`
            })
            bgPic.forEach((e) => {
                e.style.transform = `translateX(-${window.scrollY / 800}%)`
            })
        }
        if (e.wheelDelta < 0) {
            // alert("滑輪向下滾動");
            //console.log(window.scrollY)
            //console.log("滑輪向下滾動")
            mainPic.forEach((e) => {
                e.style.transform = `translateX(${window.scrollY / 1100}%)`
            })
            bgPic.forEach((e) => {
                e.style.transform = `translateX(-${window.scrollY / 800}%)`
            })
        }

    })

}
