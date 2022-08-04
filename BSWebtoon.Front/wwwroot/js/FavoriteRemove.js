let double_check_block = document.getElementById('double_check_block');
let div_btns = document.querySelector('#div_btns');
let del_btn = document.querySelector('#del_btn');




//放待刪除的陣列
var arr_to_be_del = [];

function init() {
    double_check_block.style.transform = "translateY(100%)";
    del_btn.classList.add("btn_lock");
    del_btn.setAttribute("disabled", '');
}



//檢查id 有沒有被選過 沒有的話新增至帶刪除的array
function check_del_array(div_id) {
    let repaet_index = -1;
    let repeat = false;
    arr_to_be_del.forEach((item, index) => {
        if (item == div_id) {
            repeat = true;
            repaet_index = index;
        }
    });
    if (repeat) {
        arr_to_be_del.splice(repaet_index, 1);
    } else {
        arr_to_be_del.push(div_id);
    }
    update_text();
    return repeat;
}

function cancel_double_check_block() {
    double_check_block.style.transform = "translateY(100%)";
}

function update_text() {
    let del_btn = document.getElementById('del_btn');
    let p = double_check_block.querySelector('p');

    //JIE
    var a = document.forms["main"];
    var x = a.querySelectorAll('input[type="checkbox"]:checked');

    //let length = arr_to_be_del.length;
    let length = x.length;
    del_btn.textContent = `刪除 ${length} 個作品`;
    p.innerText = `是否要刪除${length}個收藏的作品？`;
    if (length == 0) {
        del_btn.setAttribute("disabled", '');
        del_btn.setAttribute("style", "background-color: #333333");
    } else {
        del_btn.removeAttribute("disabled");
        del_btn.setAttribute("style", "background-color: #ff3042");
    }

}

//選取圖片 新增至待刪除的陣列裡 並顯示刪除幾個作品
//function select_img(img_node) {
    //let div_id = img_node.getAttribute("id");
    //let del_btn = document.getElementById('del_btn');
    //let div_cover = img_node.querySelector('div');

    //let gray_block = document.getElementsByClassName("gray_block")
    //offsetHeight 當下標籤的高度
    //let height = img_node.querySelector('img').offsetHeight + 1;
//}

//刪除圖片
function remove_all(double_check = false) {
    // console.log(double_check)
    if (double_check) {
        let comicIdsToDelete =
            Array.from(
                document.forms["main"].querySelectorAll('input[type="checkbox"]:checked')
            ).map( ckbox => ckbox.getAttribute('my_comicId') )

        console.log( comicIdsToDelete)

        fetch('/api/FavoriteApi/FavoriteRemove', {
            method: 'post',
            cache: 'no-cache',
            headers: {
                'Content-type':'application/json;charset=utf-8',
                //'Content-type':'application/json',
            },
            body: JSON.stringify(
                {
                    comicIdsToDelete: comicIdsToDelete
                    //comicIdsToDelete: [1,2],
                }
            )   
        })
        .then(resp => {
            if (resp.ok) {
                arr_to_be_del.forEach(del_item_id => {
                    let del_tag = document.getElementById(del_item_id).parentNode.parentNode;
                    del_tag.remove();
                    //window.location.reload();
                    console.log(del_item_id + '刪除成功~');
                });
                //全部刪除 直接重新宣告成空的
                
                //arr_to_be_del = [];
                //double_check_block.style.transform = "translateY(100%)";
                window.location.reload()
            } else {
                alert('刪除失敗')
            }
        })
    } else {
        double_check_block.style.transform = "translateY(0%)";
    }


    update_text();
}

init();
