var all_cols = document.querySelectorAll('div.col');

function init() {
    all_cols.forEach((col, index) => {
        col.style.transition = "all 0.5s ease";
    });
}

function Open_del_page() {
    //window.open("/Favorite/RemoveFavoriteView");
    window.location.href = '/Favorite/RemoveFavoriteView';
}

//�ǰe���e�������}����
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

//�ưʮĪG
window.addEventListener('mousewheel', (e) => {
    if (e.wheelDelta > 0) {
        // alert("�ƽ��V�W�u��");
        img_down_move();
    }
    if (e.wheelDelta < 0) {
        all_cols.forEach((col, index) => {
            col.style.transform = "translateY(0%)"
        });
        // alert("�ƽ��V�U�u��");
        div_btns.style.transform = "translateY(100px)"
    }
})

//�ƥ�W��(�����j�p���) = �n���檺�禡
window.onresize = img_down_move;

//��l��
init();