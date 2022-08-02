var all_cols = document.querySelectorAll('div.col');

function init() {
    all_cols.forEach((col, index) => {
        col.style.transition = "all 0.5s ease";
    });
}

function Open_del_page() {
    window.open("/Favorite/RemoveFavoriteView");
}

function TO_Favorite() {
    window.open("/Favorite/ReadFavoriteView");
}

function To_RecordPage() {
    window.open("/Favorite/RecordView");
}
//傳送漫畫對應網址路由
function to_comnic(node) {
    let comic_id = node.querySelector('input').value;
    console.log(comic_id);
    let url = "" + comic_id;
    // document.location.href = "https://www.google.com.tw/";
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