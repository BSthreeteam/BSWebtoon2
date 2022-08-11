let double_check_block = document.getElementById('double_check_block');
let double_check_del = document.querySelector('#double_check_del');
let div_btns = document.querySelector('#div_btns');
let del_btn = document.querySelector('#del_btn');
let main_form = document.forms["main"];
let p = double_check_block.querySelector('p');
let text_more = document.querySelector('#text_more');

//跳轉頁面
function myFunction() {
    window.location.href = '/Favorite/RecordView';
}

function init() {
    double_check_block.style.transform = "translateY(100%)";
    del_btn.classList.add("btn_lock");
    del_btn.setAttribute("disabled", '');
    update_text()
}

function cancel_double_check_block() {
    double_check_block.style.transform = "translateY(100%)";
}

function update_text() {
    let checks = main_form.querySelectorAll('input[type="checkbox"]:checked');
    let length = checks.length;
    let comic_num = document.querySelectorAll('.pic_box').length;

    del_btn.textContent = `刪除 ${length} 個作品`;
    p.innerText = `是否要刪除${length}個收藏的作品？`;
    if (length == 0) {
        del_btn.setAttribute("disabled", '');
        del_btn.setAttribute("style", "background-color: #333333");
        double_check_del.setAttribute("disabled", '');
    } else {
        del_btn.removeAttribute("disabled");
        del_btn.setAttribute("style", "background-color: #ff3042");
        double_check_del.removeAttribute("disabled");
    }

    if (comic_num == 0) {
        text_more.setAttribute("style", 'font-size:3em; color:#6c757d; ');
    } else {
        text_more.setAttribute("style", 'font-size:3em; color:#6c757d; display: none ;');
    }

}

//刪除圖片
function remove_all(double_check = false) {
    if (double_check) {
        let comicIds =
            //選取器中被打勾的checkbox狀態被選取，利用map篩選出是哪個comicId
            //Array.from是建立一個新的 Array 實體
            Array.from(
                document.forms["main"].querySelectorAll('input[type="checkbox"]:checked')
            ).map(ckbox => ckbox.getAttribute('my_comicId'))
        fetch('/api/RecordViewApi/RecordViewRemove', {
            method: 'post',
            cache: 'no-cache',
            headers: {
                'Content-type': 'application/json;charset=utf-8',
                //'Content-type':'application/json',
            },
            body: JSON.stringify(
                {
                    ComicIdsToDelete: comicIds,
                }
            )
        })
            .then(resp => {
                if (resp.ok) {
                    let all_comics = document.forms["main"].querySelectorAll('input[type="checkbox"]:checked')
                    all_comics.forEach(function (comic) {
                        comic.parentNode.parentNode.parentNode.remove();
                    });
                    Swal.fire({
                        icon: 'success',
                        title: '刪除成功!',
                        showClass: {
                            popup: 'animate__animated animate__fadeInDown'
                        },
                        hideClass: {
                            popup: 'animate__animated animate__fadeOutUp'
                        },
                        background: '#212529'
                    })
                    double_check_block.style.transform = "translateY(100%)"
                    update_text()
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: '刪除失敗!',
                    })
                }
            })
            .catch((error) => {
                console.log(`Error: ${error}`);
            })
    } else {
        double_check_block.style.transform = "translateY(0%)";
    }
    update_text();
}
init();
