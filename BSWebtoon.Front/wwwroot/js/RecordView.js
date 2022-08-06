var comicDiv = document.getElementById("ComicAdd");

function create_comic_cards() {
    if (comicsArray.ViewRecordListAll == 0) {
        let p = document.createElement('p');
        p.innerHTML = "您沒有任何觀看紀錄!";
        p.classList.add("mt-5", "NoComicList_text");
        comicDiv.append(p);
        console.log(comicsArray.ViewRecordListAll)
    }
    else {
        let getTemplate = document.getElementById("ComicTemplate");
        comicsArray.ViewRecordListAll.forEach(item => {
            let comic_template = getTemplate.content.cloneNode(true);
            comic_template.querySelector('a').text = item.EpTitle;
            let imgs = comic_template.querySelectorAll('img');
            imgs[0].src = item.BgCover;
            imgs[1].src = item.ComicWeekFigure;
            imgs[2].src = item.ComicNameImage;

            comic_template.querySelector('a').setAttribute("onclick", "to_comnic(" + item.ComicId + ")");
            imgs[0].setAttribute("onclick", "to_comnic(" + item.ComicId + ")");
            imgs[1].setAttribute("onclick", "to_comnic(" + item.ComicId + ")");
            imgs[2].setAttribute("onclick", "to_comnic(" + item.ComicId + ")");

            comicDiv.appendChild(comic_template);
            sliding_mousewheel();
        });
    }

 }

create_comic_cards();

function Comic_sort() {
    comicDiv.innerText = "";
    comicsArray.ViewRecordListAll = comicsArray.ViewRecordListAll.reverse();
    create_comic_cards();
}

function sliding_mousewheel() {

    var all_cols = document.querySelectorAll('div.col');

    function init() {
        all_cols.forEach((col, index) => {
            col.style.transition = "all 0.5s ease";
        });
    }

    function Open_del_page() {
        window.open("/Favorite/RemoveFavoriteView");
    }

    function img_down_move() {

        if (window.innerWidth >= 1200) {
            all_cols.forEach((col, index) => {
                if (index % 4 == 0) {
                    col.style.transform = "translateY(20%)"
                } else if (index % 4 == 1) {
                    col.style.transform = "translateY(40%)"
                } else if (index % 4 == 2) {
                    col.style.transform = "translateY(60%)"
                } else if (index % 4 == 3) {
                    col.style.transform = "translateY(80%)"
                }
            });
        } else {
            all_cols.forEach((col, index) => {
                if (index % 3 == 0) {
                    col.style.transform = "translateY(20%)"
                } else if (index % 3 == 1) {
                    col.style.transform = "translateY(40%)"
                } else if (index % 3 == 2) {
                    col.style.transform = "translateY(60%)"
                }
            });
        }
        div_btns.style.transform = "translateY(-30px)"
    }

    //滑動效果
    window.addEventListener('mousewheel', (e) => {
        if (e.wheelDelta > 0) {
            // alert("滑輪向上滾動");
            img_down_move();
        }
        if (e.wheelDelta < 0) {
            all_cols.forEach((col, index) => {
                col.style.transform = "translateY(0%)"
            });
            // alert("滑輪向下滾動");
            div_btns.style.transform = "translateY(100px)"
        }
    })

    //事件名稱(視窗大小更動) = 要執行的函式
    window.onresize = img_down_move;

    //初始化
    init();

}

//傳送漫畫對應網址路由
function to_comnic(comic_id) {
    let url = "/WorksPage/WorksPage/" + comic_id;
    document.location.href = url;
}