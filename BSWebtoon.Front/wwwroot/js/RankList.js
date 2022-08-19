let content = document.querySelector(".content");
let workTemplate = document.getElementById("workTemplate");
let blackTemplate = document.getElementById("blackTemplate");
let showRankTemplate = document.getElementById("showRankTemplate");
let btns = document.querySelectorAll("btns");

let categorys = document.querySelectorAll('.categorys')



window.onload = () => {
    console.log(firstcomicId);
    document.getElementById("all").setAttribute('click', getFatchall());
    getFatch();
}


function createBlack() {
    let cloneblack = blackTemplate.content.cloneNode(true);
    return cloneblack
}

function getFatch() {
    categorys.forEach(nav_a => {
        nav_a.addEventListener('click', (e) => {
            content.innerText = ""
            document.getElementById("all").classList.remove("active");
            let id = nav_a.getAttribute("my_id");
            let url = `/api/RankApi/GetRank/${id}`
            fetch(url)
                .then(response => response.json())
                .then(result => {
                    console.log(result)
                    //getFirstRank(result[0])
                    content.append(getFirstRank(result[0]))
                    for (let i = 1; i < result.length; i++) {
                        //getOtherRank(result[i])
                        content.append(getOtherRank(result[i], i))
                    }
                })
                .catch((ex) => {
                    console.log(ex);
                });
        })
    })
}

function getFatchall() {
    document.getElementById("all").classList.add("active");
    let url = `/api/RankApi/GetRank/0`
    fetch(url)
        .then(response => response.json())
        .then(result => {
            console.log(result)
            //getFirstRank(result[0])
            content.append(getFirstRank(result[0]))
            for (let i = 1; i < result.length; i++) {
                //getOtherRank(result[i])
                content.append(getOtherRank(result[i], i))
            }
        })
        .catch((ex) => {
            console.log(ex);
        });
}

function getFirstRank(result) {
    let cloneRank = showRankTemplate.content.cloneNode(true);
    cloneRank.querySelector(".banner").href = `/WorksPage/WorksPage/${result.ComicId}`
    cloneRank.querySelector(".rank_pic_bg").src = result.BgCover
    cloneRank.querySelector(".rank_pic_title").src = result.ComicNameImage
    if (result.BannerVideoWeb != "") {
        cloneRank.querySelector(".video").src = result.BannerVideoWeb
        cloneRank.querySelector(".rank_pic_people").style.display = "none";
    }
    else {
        cloneRank.querySelector(".rank_pic_people").src = result.ComicFigure
        cloneRank.querySelector("#movie").style.display= "none";

    }
    cloneRank.querySelector(".introduction").innerText = result.Introduction.slice(0, 40)
    cloneRank.querySelector(".diff").innerText = result.Diff
    if (result.Diff >= 0) {
        cloneRank.querySelector(".fa-caret-down").style.display = "none";
    }
    else {
        cloneRank.querySelector(".fa-caret-up").style.display = "none";
    }

    return cloneRank;
}

function getOtherRank(result, index) {
    let cloneotherRank = workTemplate.content.cloneNode(true);
    //console.log(cloneotherRank);
    cloneotherRank.querySelector(".work").href = `/WorksPage/WorksPage/${result.ComicId}`
    cloneotherRank.querySelector(".rankCardCover").src = result.BgCover
    cloneotherRank.querySelector(".work_pic").src = result.ComicWeekFigure
    cloneotherRank.querySelector(".work_pic").alt = result.ComicName
    cloneotherRank.querySelector(".rankCardName").src = result.ComicNameImage
    cloneotherRank.querySelector(".rankCardName").alt = result.ComicName
    //cloneRank.querySelector(".Ranking_num").alt = result.ComicName
    cloneotherRank.querySelector(".diff").innerText = result.Diff
    if (result.Diff >= 0) {
        cloneotherRank.querySelector(".fa-caret-down").style.display = "none";
    }
    else {
        cloneotherRank.querySelector(".fa-caret-up").style.display = "none";
    }
    cloneotherRank.querySelector(".Ranking_num").innerText = index + 1

    return cloneotherRank;
}

