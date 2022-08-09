const app = new Vue({
    el: '#app',
    //資料, state
    data: {
        // 註冊表單資料
        signup: {
            ActivityName: '',
            //file1: null,
            ActivityBgColor: '',
            ActivityStartTime: '',
            ActivityEndTime: '',
            CreateTime: '',
            ActivityContent: '',
            ActivityEmployeeName: ''

        },
        // 註冊表單驗證相關
        signupCheck: {
            ActivityNameError: false,
            ActivityNameErrorMsg: '',

            //file1Error: false,
            //file1ErrorMsg: '',

            ActivityBgColorError: false,
            AActivityBgColorErrorMsg: '',

            ActivityStartTimeError: false,
            ActivityStartTimeErrorMsg: '',

            ActivityEndTimeError: false,
            ActivityEndTimeErrorMsg: '',

            ActivityContentError: false,
            ActivityContentErrorMsg: '',

            ActivityEmployeeNameError: false,
            ActivityEmployeeNameErrorMsg: '',

        },
        // 送出按鈕驗證
        addVerify: true



    },

    //監聽區
    watch: {
        'signup.ActivityName': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityName == '') {
                    this.signupCheck.ActivityNameError = true
                    this.signupCheck.ActivityNameErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityNameError = false
                    this.signupCheck.ActivityNameErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        //'signup.file1': {
        //    immediate: true,
        //    // X: handler: () => {
        //    handler: function() {
        //        // TODO:
        //        // 不得為空
        //        if (this.signup.file1 == null) {
        //            this.signupCheck.file1Error = true
        //            this.signupCheck.file1ErrorMsg = '不得為空!'
        //        }
        //        //// 大於8碼
        //        //else if (this.signup.account.length < 8) {
        //        //    this.signupCheck.accountError = true
        //        //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
        //        //}
        //        // 成功時 消除errorMsg, errorStatus
        //        else {
        //            this.signupCheck.file1Error = false
        //            this.signupCheck.file1ErrorMsg = ''
        //        }

        //        //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
        //        this.checkAddVerify()
        //    }
        //},
        'signup.ActivityBgColor': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityBgColor == '') {
                    this.signupCheck.ActivityBgColorError = true
                    this.signupCheck.ActivityBgColorErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityBgColorError = false
                    this.signupCheck.ActivityBgColorErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'signup.ActivityStartTime': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityStartTime == '') {
                    this.signupCheck.ActivityStartTimeError = true
                    this.signupCheck.ActivityStartTimeErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityStartTimeError = false
                    this.signupCheck.ActivityStartTimeErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'signup.ActivityEndTime': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityEndTime == '') {
                    this.signupCheck.ActivityEndTimeError = true
                    this.signupCheck.ActivityEndTimeErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityEndTimeError = false
                    this.signupCheck.ActivityEndTimeErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'signup.ActivityContent': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityContent == '') {
                    this.signupCheck.ActivityContentError = true
                    this.signupCheck.ActivityContentErrorMsg = '不得為空!'
                }
                // 大於8碼
                else if (this.signup.ActivityContent.length > 500) {
                    this.signupCheck.ActivityContentError = true
                    this.signupCheck.ActivityContentErrorMsg = '不得超過於500字!'
                }
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityContentError = false
                    this.signupCheck.ActivityContentErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'signup.ActivityEmployeeName': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.signup.ActivityEmployeeName == '') {
                    this.signupCheck.ActivityEmployeeNameError = true
                    this.signupCheck.ActivityEmployeeNameErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.ActivityEmployeeNameError = false
                    this.signupCheck.ActivityEmployeeNameErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
    },

    //方法區
    methods: {
        //確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
        checkAddVerify() {
            //先把所有的輸入框的狀態，一個一個跌帶出來
            for (let prop in this.signupCheck) {
                //預設所有的輸入框都要輸入正確的值，把預設為false狀態改成true。
                if (this.signupCheck[prop] == true) {
                    //開啟按鈕
                    this.addVerify = true
                    //回傳
                    return
                }
                //禁用按鈕
                this.addVerify = false
            }
        }
    }
})




////var arrCover = []; //存人物圖檔
var ActivityImage = document.getElementById("ActivityImage")
ActivityImage.addEventListener("change", readURL);
var obj, input_ActivityImage, img_box;
img_box = document.querySelector('#img_box');
//存人物圖檔
function readURL() {
    img_box.innerText = "";
    input_ActivityImage = this;

    for (var i = 0; i < input_ActivityImage.files.length; i++) {
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
                    if (1024 >= width && height >= 572) {
                        //alert("檔案尺寸符合！");

                    } else {
                        alert("檔案尺寸應為：1024 ~ 572 區間！");
                        input_ActivityImage.value = "";
                        //obj_cover.files = []; //會失敗 FileList不能set?
                        img_box.innerText = "";
                        return false;
                    }
                };

                image.src = cover_src;

                let img_cover = document.createElement('img');
                img_cover.setAttribute('src', cover_src);
                img_cover.classList.add("mw-100")
                img_cover.classList.add("mx-auto")
                img_box.appendChild(img_cover);
            }
        })(i)
        reader.readAsDataURL(input_ActivityImage.files[i]);
    }
}