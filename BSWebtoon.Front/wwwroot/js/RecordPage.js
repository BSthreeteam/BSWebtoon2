function Open_del_page() {
    //window.open("/Favorite/RemoveFavoriteView");
    window.location.href = '/Favorite/RemoveFavoriteView';
}

function TO_Favorite() {
    window.open("/Favorite/ReadFavoriteView");
}

//傳送漫畫對應網址路由
function to_comnic(node) {
    let comic_id = node.querySelector('input').value;
    console.log(comic_id);
    let url = "" + comic_id;
    // document.location.href = "https://www.google.com.tw/";
}
let all_cols = document.querySelectorAll('div.col');

//滑動效果
window.addEventListener('mousewheel', (e) => {
    all_cols.forEach((col, index) => {
        col.style.transition = "all 0.5s ease";
    });
    if (e.wheelDelta > 0) {
        // alert("滑輪向上滾動");
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
    if (e.wheelDelta < 0) {
        all_cols.forEach((col, index) => {
            col.style.transform = "translateY(0%)"
        });
        // alert("滑輪向下滾動");
        div_btns.style.transform = "translateY(100px)"
    }
})