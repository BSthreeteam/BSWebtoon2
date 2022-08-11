var upload_work = document.getElementById("upload_file_btn")



//var inputState =  document.getElementById("inputState")
// inputState.addEventListener("change", Checkselect);
// function Checkselect() {

//     let comic_text = document.getElementsByClassName('comic_text')[0];
//     comic_text.setAttribute('class', 'd-none');

// }



//上傳多個文件方法
//input file已增加multiple屬性，按住ctrl可選擇多圖
var arrTitle = []; //存標題名
var arrCover = []; //存封面圖檔

//(Yu)上傳集數封面
var input_EP_Cover = document.getElementById("EpCover")
input_EP_Cover.addEventListener("change", readURL);

var input_EP_Context = document.getElementById("EP_Context_file")
input_EP_Context.addEventListener("change", file);



var obj, img_box;
img_box = document.querySelector('#img_box');

function readURL() {
    img_box.innerText = "";
    let length = input_EP_Cover.files.length;
    for (var i = 0; i < length; i++) {

        var reader = new FileReader();
        //if (!reader) {
        //    alert("對不起，您的瀏覽器不支持!請更換瀏覽器試一下");
        //    return
        //}
        //reader.error = function(e) {
        //    alert("讀取異常")
        //}
        //儲存上傳的封面圖片
        let file_cover_name = input_EP_Cover.files[i].name;
        arrCover.push(file_cover_name);
        (function (i) {
            reader.onload = function (e) {
                let cover_src = e.target.result;

                //載入圖片獲取圖片真實寬度和高度
                var image = new Image();
                image.onload = function () {
                    var width = image.width;
                    var height = image.height;
                    if (width == 250 | height == 150) {
                        //alert("檔案尺寸符合！");
                        let img_cover = document.createElement('img');
                        img_cover.setAttribute('src', cover_src);
                        img_cover.classList.add("mw-100")
                        img_cover.classList.add("h-50")
                        img_cover.classList.add("my-auto")
                        img_box.appendChild(img_cover);


                    } else {
                        alert("檔案尺寸應為：250*150！");
                        input_EP_Cover.value = "";
                        img_box.innerText = ""; //只有視覺
                        checkSendable();
                        return false;
                        //BgCover  input要清除
                    }
                };

                image.src = cover_src;
            }
        })(i)
        reader.readAsDataURL(input_EP_Cover.files[i]);
    }


    checkSendable();
}


//function file() {
//    obj = this,
//        length = obj.files.length;
//    _html = '';

//    for (var i = 0; i < length; i++) {
//        var reader = new FileReader();
//        if (!reader) {
//            console.log('對不起，您的瀏覽器不支持！請更換瀏覽器試一下');
//            return
//        }
//        reader.error = function(e) {
//            console.log("讀取異常")
//        }
//        //存儲上傳的多張圖片名字
//        let file_name = obj.files[i].name;
//        //arrTitle.push(file_name);
//        //iffi語法
//        ;
//        //(function(i) {
//            //讀取成功
//            reader.onload = function(e) {
//                let _src = e.target.result;
//                // console.log(e.target.result);

//                let image = new Image();
//                image.onload = function() {
//                    if (image.height != 886 || image.width != 600) {
//                        console.log(file_name + " 不符合圖片推薦大小");
//                        alert(file_name + " 不符合圖片推薦大小");
//                    } else {
//                        arrTitle.pop(file_name);
//                        //一個檔案的區塊 item_block
//                        let div_item = document.createElement('div');
//                        // div_item.setAttribute('class', 'item');
//                        ///(Yu)加入class
//                        div_item.classList.add("d-flex", "flex-column", 'ui-state-default');
//                        //XX的按鈕
//                        let pic_del_btn = document.createElement('button');
//                        pic_del_btn.setAttribute('type', "button");
//                        pic_del_btn.setAttribute('aria-label', "Close");
//                        pic_del_btn.setAttribute('title', file_name);
//                        pic_del_btn.classList.add("btn-close", "btn-close-white", "pic_del_btn");
//                        //圖片
//                        let img_div = document.createElement('div');
//                        // img_div.classList.add('text-end');
//                        let img = document.createElement('img');
//                        img.setAttribute('src', _src);
//                        img.setAttribute('style', "width: 250px; height: 300px;");
//                        img_div.appendChild(img);
//                        //檔案名稱
//                        let span_file_name = document.createElement('span');
//                        span_file_name.innerHTML = file_name;
//                        div_item.appendChild(pic_del_btn);
//                        div_item.appendChild(img_div);
//                        div_item.appendChild(span_file_name);

//                        //增加節點結構
//                        let sortable = document.getElementById('sortable');
//                        sortable.insertBefore(div_item, sortable.firstChild);

//                        //刪除節點方法
//                        pic_del_btn.onclick = function() {
//                            removeItem(this);
//                            return false;
//                        };
//                    }
//                };

//                //放入內容
//                image.src = _src;



//            };




//})(i)


let sortable = document.getElementById("sortable");
let aa = true;


function file() {
    let obj = input_EP_Context,
       _html = '';

    var ff;
    aa = true

    for (var i = 0; i < obj.files.length; i++) {

        var reader = new FileReader();
        if (!reader) {
            console.log('對不起，您的瀏覽器不支持！請更換瀏覽器試一下');
            return
        }

        reader.error = function (e) {
            console.log("讀取異常")
        }
        let file_name = obj.files[i].name;
        //iffi語法

        (function (i) {
            //讀取成功
        })(i)

        reader.onload = function (e) {

            let _src = e.target.result;
            //建立圖標籤
            let image = new Image();
            image.onload = function () {
                if (image.height != 886 || image.width != 600) {
                    console.log(file_name + " 不符合圖片推薦大小");
                    let flag = confirm(file_name + " 不符合圖片推薦大小");

                    input_EP_Context.value = "";
                    //window.location.reload();

                    input_EP_Context.innerText = null;


                    //arrTitle.pop(file_name);
                    //aa = false;
                }

                else {
                    //存儲上傳的多張圖片名字
                    arrTitle.push(file_name);
                    // console.log(e.target.result);
                    //一個檔案的區塊 item_block
                    let div_item = document.createElement('div');
                    // div_item.setAttribute('class', 'item');
                    ///(Yu)加入class
                    div_item.classList.add("d-flex", "flex-column", 'ui-state-default');
                    //XX的按鈕
                    let pic_del_btn = document.createElement('button');
                    pic_del_btn.setAttribute('type', "button");
                    pic_del_btn.setAttribute('aria-label', "Close");
                    pic_del_btn.setAttribute('title', file_name);
                    pic_del_btn.classList.add("btn-close", "btn-close-white", "pic_del_btn");
                    //圖片
                    let img_div = document.createElement('div');
                    // img_div.classList.add('text-end');
                    let img = document.createElement('img');
                    img.setAttribute('src', _src);
                    img.setAttribute('style', "width: 250px; height: 300px;");
                    img_div.appendChild(img);
                    //檔案名稱
                    let span_file_name = document.createElement('span');
                    span_file_name.innerHTML = file_name;
                    div_item.appendChild(pic_del_btn);
                    div_item.appendChild(img_div);
                    div_item.appendChild(span_file_name);

                    //增加節點結構
                    let sortable = document.getElementById('sortable');
                    sortable.insertBefore(div_item, sortable.firstChild);

                    //刪除節點方法
                    pic_del_btn.onclick = function () {
                        removeItem(this);
                        return false;
                    };
                }
            };

            //放入內容
            image.src = _src;

        };
        reader.onprogress = function (e) {
            if (e.lengthComputable) {
                console.log("正在讀取文件")
            }
        };
        reader.readAsDataURL(obj.files[i]);

        //reader.onloadend = function() {
        //    update_file_state();
        //}
    }

    checkSendable();
    if (!aa) {
        removeItemAll();
    }
}

checkSendable();

function checkSendable() {
    if (input_EP_Context.files.length > 0 && input_EP_Cover.files.length > 0) {
        upload_work.disabled = false;
    } else {
        upload_work.disabled = true;
    }
}

function update_file_state() {
    if (arrTitle.length == 0) {
        document.getElementById("EP_Context_file").value = "";
        document.getElementById("select_file").innerHTML = "選擇檔案  ";
    } else if (arrTitle.length == 1) {
        //只有一個檔案的話 顯示檔名
        document.getElementById("select_file").innerHTML = "選擇檔案  " + arrTitle[0];
    } else {
        //否則顯示數量
        document.getElementById("select_file").innerHTML = "選擇檔案  " + arrTitle.length + " 個檔案";
    }
}

//刪除圖片
function removeItem(delNode) {
    var itemNode = delNode.parentNode,
        title = delNode.getAttribute('title');
    var flag = confirm("確認要刪除名爲：" + title + "的圖片？");
    if (flag) {
        itemNode.parentNode.removeChild(itemNode);
        console.log('刪除成功~');
        //標題變數也要砍掉
        arrTitle.pop(title);
        update_file_state();
    }
    checkSendable();
    return false;
}
//刪除全部圖片
function removeItemAll() {

    if (arrTitle.length == 0) {
        alert("尚未選擇任何檔案!");
    } else if (confirm("確認刪除全部的圖片嗎?") == true) {
        // 下面顯示的 也清空 這樣使用者看起來才是空的
        document.getElementById("sortable").innerText = null;
        console.log(arrTitle);
        arrTitle = [];
        update_file_state();
    } else {
        return false;
    }
    upload_work.disabled = true;
}




//上傳等待狀態按鈕
//var Wait = document.getElementById("Wait");
upload_work.addEventListener("click", Waiting_Upload);
var Loadingdata = document.getElementById("Loadingdata");
//上傳等待狀態按鈕方法
function Waiting_Upload() {
    if (confirm("確定上傳檔案嗎?") == true) {
        alert("上傳中...")
    } else {
        return false;
    }

    Loadingdata.classList.add("spinner-border");
    Loadingdata.classList.add("text-warning");
    //upload_work.setAttribute('disabled', disabled);

    //upload_work.setAttribute('class', bg - secondary);
    //upload_work.setAttribute('class', p - 2);
    //upload_work.setAttribute('class', text - dark);
    //upload_work.setAttribute('class', bg - opacity - 25);

}



$("#sortable").sortable({
    cursor: "move",
    item: ">li",
    opacity: 0.6,
    axis: "y",
    //更新排序之後的 陣列
    //當排序動作結束時且元素座標已經發生改變時觸發此(update)事件。
    update: function (event, ui) {
        // console.log($(this).sortable('toArray'));

    }
});