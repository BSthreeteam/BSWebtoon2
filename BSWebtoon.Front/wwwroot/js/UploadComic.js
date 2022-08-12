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


var ComicChineseName = document.getElementById("ComicChineseName");
var ComicTagList = document.getElementById("ComicTagList");
var PublishDate = document.getElementById("PublishDate");
var UpdateWeek = document.getElementById("UpdateWeek");
var Painter = document.getElementById("Painter");
var ReadAuthor = document.getElementById("ReadAuthor");
var WriteAuthor = document.getElementById("WriteAuthor");
var Introduction = document.getElementById("Introduction");
var gridCheck = document.getElementById("gridCheck");
var ComicFigureMsg = document.getElementById("ComicFigureMsg");

let IsComicFigureCover = false;
let IsBgCover = false;
let IsComicChineseName = false;
let IsComicTagList = false;
let IsPublishDate = false;
let IsPainter = false;
let IsAuthor = false;
let IsIntroduction = false;



//上傳等待狀態按鈕
let upload_work = document.getElementById("upload_work");
upload_work.disabled = true;

//const app = new Vue({
//    el: '#app',
//    //資料, state
//    data: {
//        // 註冊表單資料

//        signup: {
//            //預設資料的值
//            //ComicChineseName: ComicChineseName.value,
//            ComicChineseName: '',
//            ComicTagList: '',
//            //ComicTagList: ComicTagList.value,
//            PublishDate: PublishDate.value,
//            UpdateWeek: UpdateWeek.value,
//            Painter: Painter.value,
//            ReadAuthor: ReadAuthor.value,
//            WriteAuthor: '',
//            Introduction: '',
//            gridCheck: false,

//        },
//        // 註冊表單驗證相關
//        signupCheck: {
//            ComicChineseNameError: false,
//            ComicChineseNameErrorMsg: '',

//            ComicTagListError: false,
//            ComicTagListErrorMsg: '',

//            PublishDateError: false,
//            PublishDateErrorMsg: '',

//            UpdateWeekError: false,
//            UpdateWeekErrorMsg: '',

//            PainterError: false,
//            PainterErrorMsg: '',

//            ReadAuthorError: false,
//            ReadAuthorErrorMsg: '',

//            WriteAuthorError: false,
//            WriteAuthorErrorMsg: '',

//            IntroductionError: false,
//            IntroductionErrorMsg: '',

//            gridCheckError: false,
//            gridCheckErrorMsg: '',

//        },
//        // 送出按鈕驗證
//        addVerify: true,
//        //打勾驗證
//        isVisiable: true,

//    },

//    //監聽區
//    watch: {
//        'signup.ComicChineseName': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.ComicChineseName == '') {
//                    this.signupCheck.ComicChineseNameError = true
//                    this.signupCheck.ComicChineseNameErrorMsg = '不得為空!'
//                }
//                //// 大於8碼
//                //else if (this.signup.account.length < 8) {
//                //    this.signupCheck.accountError = true
//                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
//                //}
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.ComicChineseNameError = false
//                    this.signupCheck.ComicChineseNameErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.ComicTagList': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.ComicTagList == '') {
//                    this.signupCheck.ComicTagListError = true
//                    this.signupCheck.ComicTagListErrorMsg = '不得為空!'
//                }
//                //// 大於8碼
//                //else if (this.signup.account.length < 8) {
//                //    this.signupCheck.accountError = true
//                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
//                //}
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.ComicTagListError = false
//                    this.signupCheck.ComicTagListErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.PublishDate': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.PublishDate == '') {
//                    this.signupCheck.PublishDateError = true
//                    this.signupCheck.PublishDateErrorMsg = '不得為空!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.PublishDateError = false
//                    this.signupCheck.PublishDateErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.UpdateWeek': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.UpdateWeek == '') {
//                    this.signupCheck.UpdateWeekError = true
//                    this.signupCheck.UpdateWeekErrorMsg = '不得為空!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.UpdateWeekError = false
//                    this.signupCheck.UpdateWeekErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.Painter': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.Painter == '') {
//                    this.signupCheck.PainterError = true
//                    this.signupCheck.PainterErrorMsg = '不得為空!'
//                }
//                // 大於8碼
//                else if (this.signup.Painter.length > 25) {
//                    this.signupCheck.PainterError = true
//                    this.signupCheck.PainterErrorMsg = '不得大於25字!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.PainterError = false
//                    this.signupCheck.PainterErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.ReadAuthor': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.ReadAuthor == '') {
//                    this.signupCheck.ReadAuthorError = true
//                    this.signupCheck.ReadAuthorErrorMsg = '不得為空!'
//                }
//                // 大於8碼
//                else if (this.signup.ReadAuthor.length > 25) {
//                    this.signupCheck.ReadAuthorError = true
//                    this.signupCheck.ReadAuthorErrorMsg = '不得大於25字!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.ReadAuthorError = false
//                    this.signupCheck.ReadAuthorErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.WriteAuthor': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.WriteAuthor == '') {
//                    this.signupCheck.WriteAuthorError = true
//                    this.signupCheck.WriteAuthorErrorMsg = '不得為空!'
//                }
//                // 不得大於25
//                else if (this.signup.WriteAuthor.length > 25) {
//                    this.signupCheck.WriteAuthorError = true
//                    this.signupCheck.WriteAuthorErrorMsg = '不得大於25字!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.WriteAuthorError = false
//                    this.signupCheck.WriteAuthorErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.Introduction': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.Introduction == '') {
//                    this.signupCheck.IntroductionError = true
//                    this.signupCheck.IntroductionErrorMsg = '不得為空!'
//                }
//                // 不得大於500
//                else if (this.signup.Introduction.length > 500) {
//                    this.signupCheck.IntroductionError = true
//                    this.signupCheck.IntroductionErrorMsg = '不得大於500字!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.IntroductionError = false
//                    this.signupCheck.IntroductionErrorMsg = ''
//                }

//                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                this.checkAddVerify()
//            }
//        },
//        'signup.gridCheck': {
//            immediate: true,
//            // X: handler: () => {
//            handler: function () {
//                // TODO:
//                // 不得為空
//                if (this.signup.gridCheck == false) {
//                    this.signupCheck.gridCheckError = true
//                    this.signupCheck.gridCheckErrorMsg = '不得為空!'
//                }
//                // 成功時 消除errorMsg, errorStatus
//                else {
//                    this.signupCheck.gridCheckError = false
//                    this.signupCheck.gridCheckErrorMsg = ''
//                }

//                ////呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//                //this.checkAddVerify()
//            }
//        },
//    },

//    //方法區
//    methods: {
//        //確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
//        checkAddVerify() {
//            //先把所有的輸入框的狀態，一個一個跌帶出來
//            for (let prop in this.signupCheck) {
//                //預設所有的輸入框都要輸入正確的值，把預設為false狀態改成true。
//                if (this.signupCheck[prop] == true) {
//                    //禁用按鈕
//                    this.addVerify = true
//                    //回傳
//                    return
//                }
//                //開啟按鈕
//                this.addVerify = false
//            }
//        },

//        change() {

//            if (this.isVisiable = !this.isVisiable ) {

//                //禁用按鈕
//                this.addVerify = true
//                //回傳
//                return
//            }
//            else {
//                //開啟按鈕
//                this.addVerify = false
//            }

//        }
//    }
//})




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
                img_cover.classList.add("mw-100");
                img_cover.classList.add("mh-100");
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
                //img_cover.classList.add("w-100")
                img_box_BgCover.appendChild(img_cover);
            }
        })(i)
        reader.readAsDataURL(input_BgCover.files[i]);
    }

}



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

CheckSendable();

function CheckSendable() {
    
    //CheckComicFigureCover();
    //CheckBgCover();
    CheckComicChineseName();
    CheckComicTagList();
    CheckPublishDate();
    CheckPainter();
    CheckAuthor();
    CheckIntroduction();
    if ( IsComicChineseName && IsComicTagList && IsPublishDate && IsPainter && IsAuthor && IsIntroduction) {

        upload_work.disabled = true;
    } else {
        upload_work.disabled = false;

    }


}



//function CheckComicFigureCover() {

//    if (input_ComicFigureCover.files.length > 0) {
//        IsComicFigureCover = true;
//    }
//    else {

//        IsComicFigureCover = false;
//    }

//}

function CheckBgCover() {
    if (input_BgCover.files.length > 0) {
        IsBgCover = true;
    } else {
        IsBgCover = false;
    }
}

function CheckComicChineseName() {
    if (ComicChineseName.value != null && ComicChineseName.length > 0) {
        IsComicChineseName = true;
        return;
    }


}

function CheckComicTagList() {
    if (ComicTagList.length > 0) {
        IsComicTagList = true;
    } else {
        IsComicTagList = false;
    }
}

function CheckPublishDate() {
    if (PublishDate.value != null) {
        IsPublishDate = true;
    } else {
        IsPublishDate = false;
    }
}

function CheckPainter() {
    if (Painter.length > 0 | Painter.length < 25) {
        IsPainter = true;
    } else {
        IsPainter = false;
    }
}

function CheckAuthor() {
    if (ReadAuthor.length > 0 | ReadAuthor.length < 25) {
        IsAuthor = true;
    } else {
        IsAuthor = false;
    }
}

function CheckIntroduction() {
    if (Introduction.length > 0 | Introduction.length < 500) {
        IsIntroduction = true;
    } else {
        IsIntroduction = false;
    }
}


