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

//ok
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
function select_img(img_node) {
    let div_id = img_node.getAttribute("id");
    let del_btn = document.getElementById('del_btn');
    let div_cover = img_node.querySelector('div');
    //offsetHeight 當下標籤的高度
    let height = img_node.querySelector('img').offsetHeight + 1;
    // console.log(height);



    if (!check_del_array(div_id)) {
        div_cover.classList.add("gray_block");
        img_node.querySelector('div').setAttribute('style', `height: ${height}px;`);
        img_node.querySelector('.check_btn').classList.add("check_btn_bag_red");
        alert("1");
    } else {
        div_cover.classList.remove("gray_block");
        img_node.querySelector('.check_btn').classList.remove("check_btn_bag_red");
        img_node.querySelector('div').setAttribute('style', `height: 0px;`);
        alert("2");
    }
}

//刪除圖片 
function remove_all(double_check = false) {
     //console.log(double_check)
    if (double_check) {
        alert("56");

        arr_to_be_del.forEach(del_item_id => {
            let del_tag = document.getElementById(del_item_id).parentNode.parentNode;
            del_tag.remove();
            console.log(del_item_id + '刪除成功~');
        });
        //全部刪除 直接重新宣告成空的
        arr_to_be_del = [];
        double_check_block.style.transform = "translateY(100%)";
    } else {
        alert("556");

        double_check_block.style.transform = "translateY(0%)";
    }
    update_text();
}

init();
