//let ComicTagList_Choose = document.getElementById("ComicTagList_Choose");
//    document.getElementById("ComicTagList").addEventListener("change", Checkselect ).Value;
//let Choose = document.getElementById("ComicTagList").Value;
//function Checkselect() {
//    if (Choose == 1) {
//        let Checkselect_p = document.createElement('p');
//        Checkselect_p.innerText = "必須輸入";
//        ComicTagList_Choose.append(Checkselect_p);
//    }
//}





//var arrCover = []; //存人物圖檔
document.getElementById("ComicFigure")
    .addEventListener("change", readURL);
var obj, input_ComicFigureCover, img_box;
img_box = document.querySelector('#img_box');
//存人物圖檔
function readURL() {
    img_box.innerText = "";
    input_ComicFigureCover = this;

    for (var i = 0; i < input_ComicFigureCover.files.length; i++) {
        var reader = new FileReader();

        //儲存上傳的封面圖片
        //let file_cover_name = obj_cover.files[i].name;
        //arrCover.push(file_cover_name);
        (function (i) {
            reader.onload = function (e) {
                let cover_src = e.target.result;

                //載入圖片獲取圖片真實寬度和高度
                var image = new Image();
                image.onload = function () {
                    var width = image.width;
                    var height = image.height;
                    if (width == 710 | height == 600) {
                        //alert("檔案尺寸符合！");

                    } else {
                        alert("檔案尺寸應為：710 × 600！");
                        input_ComicFigureCover.value = "";
                        //obj_cover.files = []; //會失敗 FileList不能set?
                        img_box.innerText = "";
                        return false;
                    }
                };

                image.src = cover_src;

                let img_cover = document.createElement('img');
                img_cover.setAttribute('src', cover_src);
                img_cover.classList.add("w-100")
                img_box.appendChild(img_cover);
            }
        })(i)
        reader.readAsDataURL(input_ComicFigureCover.files[i]);
    }
}



//var BgCover = []; //存背景圖檔
document.getElementById("BgCover")
    .addEventListener("change", BgCover_readURL);
var input_BgCover, img_box_BgCover;
img_box_BgCover = document.querySelector('#img_box_BgCover');
//存背景圖檔
function BgCover_readURL() {
    img_box_BgCover.innerText = "";
    input_BgCover = this;

    for (var i = 0; i < input_BgCover.files.length; i++) {

        var reader = new FileReader();

        //儲存上傳的封面圖片 ? 存背景圖檔?
        let file_cover_name = input_BgCover.files[i].name;
        //BgCover.push(file_cover_name);
        (function (i) {
            reader.onload = function (e) {
                let cover_src = e.target.result;

                //載入圖片獲取圖片真實寬度和高度
                var image = new Image();
                image.onload = function () {
                    var width = image.width;
                    var height = image.height;
                    if (width == 375 | height == 812) {
                        //alert("檔案尺寸符合！");

                    } else {
                        alert("檔案尺寸應為：375 × 812！");
                        input_BgCover.value = "";
                        img_box_BgCover.innerText = "";
                        return false;

                    }
                };

                image.src = cover_src;


                let img_cover = document.createElement('img');
                img_cover.setAttribute('src', cover_src);
                img_cover.classList.add("w-100")
                img_box_BgCover.appendChild(img_cover);
            }
        })(i)
        reader.readAsDataURL(input_BgCover.files[i]);
    }
}


//上傳等待狀態按鈕
var upload_work = document.getElementById("upload_work");
upload_work.addEventListener("click", Waiting_Upload);
var Loadingdata = document.getElementById("Loadingdata");

//上傳等待狀態按鈕方法
function Waiting_Upload() {
    Loadingdata.classList.add("spinner-border");
    Loadingdata.classList.add("text-warning");
    //upload_work.setAttribute('disabled', 'disabled');

    upload_work.setAttribute('class', 'bg-secondary');
    upload_work.setAttribute('class', 'p-2');
    upload_work.setAttribute('class', 'text-dark');
    upload_work.setAttribute('class', 'bg-opacity-25');
}

        //bg-secondary p-2 text-dark bg-opacity-25