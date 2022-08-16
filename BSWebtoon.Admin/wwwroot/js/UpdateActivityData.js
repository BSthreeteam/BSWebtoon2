
const app = new Vue({
    el: '#app',
    data: {
        ActivityList: [],
        //編輯
        currentActivity: {},
        value: "",
    },
    mounted() {
        this.getAllActivityList()
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

        previewImage(e) {
            const
                originalFile = e.target.files[0]
            console.log(e)
            if (originalFile) {
                let reader = new FileReader();
                reader.readAsDataURL(originalFile);
                reader.onload = (re) => {
                    console.log(re)
                    console.log(e.target.id)
                    this.currentActivity[e.target.id] = re.target.result
                };
            }
        },
        selectEdit(Activity) {
            value = this.ActivityList.activityStartTime;
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



