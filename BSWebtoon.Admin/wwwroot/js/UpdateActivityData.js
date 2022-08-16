
const app = new Vue({
    el: '#app',
    data: {
        ActivityList: [],
        //編輯
        currentActivity: {
            activityName: '',
            activityStartTime: '',
            activityEndTime: '',
            
            activityContent: '',
        },
        signupCheck: {
            activityNameError: false,
            activityNameErrorMsg: '',

            activityStartTimeError: false,
            activityStartTimeErrorMsg: '',

            activityEndTimeError: false,
            activityEndTimeErrorMsg: '',

            

            activityContentError: false,
            activityContentErrorMsg: '',
        },

        addVerify: true
        
    },
    mounted() {
        this.getAllActivityList()
    },
    //監聽區
    watch: {
        'currentActivity.activityName': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.currentActivity.activityName == '') {
                    this.signupCheck.activityNameError = true
                    this.signupCheck.activityNameErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.activityNameError = false
                    this.signupCheck.activityNameErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'currentActivity.activityStartTime': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.currentActivity.activityStartTime == '') {
                    this.signupCheck.activityStartTimeError = true
                    this.signupCheck.activityStartTimeErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.activityStartTimeError = false
                    this.signupCheck.activityStartTimeErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'currentActivity.activityEndTime': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.currentActivity.activityEndTime == '') {
                    this.signupCheck.activityEndTimeError = true
                    this.signupCheck.activityEndTimeErrorMsg = '不得為空!'
                }
                //// 大於8碼
                //else if (this.signup.account.length < 8) {
                //    this.signupCheck.accountError = true
                //    this.signupCheck.accountErrorMsg = '帳號不得小於8碼!'
                //}
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.activityEndTimeError = false
                    this.signupCheck.activityEndTimeErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        'currentActivity.activityContent': {
            immediate: true,
            // X: handler: () => {
            handler: function () {
                // TODO:
                // 不得為空
                if (this.currentActivity.activityContent == '') {
                    this.signupCheck.activityContentError = true
                    this.signupCheck.activityContentErrorMsg = '不得為空!'
                }
                // 大於8碼
                else if (this.currentActivity.activityContent.length > 500) {
                    this.signupCheck.activityContentError = true
                    this.signupCheck.activityContentErrorMsg = '不得超過於500字!'
                }
                // 成功時 消除errorMsg, errorStatus
                else {
                    this.signupCheck.activityContentError = false
                    this.signupCheck.activityContentErrorMsg = ''
                }

                //呼叫確認所有的輸入框都要輸入正確的值，點擊送出按鈕的方法。
                this.checkAddVerify()
            }
        },
        
    },

    methods: {
        getAllActivityList() {
            axios.get('/api/UpdateActivityApi/Read')
                .then((res) => {
                    
                        console.log(res)
                    this.ActivityList = res.data.map(x => {
                        //把日期時間做轉型
                        x.activityStartTime = x.activityStartTime.split('T')[0]
                        x.activityEndTime = x.activityEndTime.split('T')[0]
                        x.createTime = x.createTime.split('T')[0]
                        return x
                    })
                    
                })
        },

       
        selectEdit(Activity) {
           
            this.currentActivity = { ...Activity }
            
        },
        updateActivity() {
            let formData = new FormData()
            let keyList = Object.keys(this.currentActivity);
            keyList.forEach(key => {
                let value = this.currentActivity[key];
                console.log(value)
                formData.append(`${key}`, this.currentActivity[key]);
            })
            formData.append("data", this.currentActivity);
            axios({
                method: 'post',
                url: '/api/UpdateActivityApi/Update',
                data: formData,
                header: {
                    'Content-Type': 'multipart/form-data'
                },
            })
                .then((res) => {
                    //在API自訂的狀態碼 status
                    this.getAllPokemon()
                    //關閉modal視窗
                    $('#edit-modal').modal('hide')


                    //if (res.data.status === 20000) {
                    //    toastr.success('更新成功')
                    //} else {
                    //    toastr.error('更新失敗')
                    //}
                })
                .catch((error) => { console.log(error) })
        },

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
        },

    },
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



