
let release_area = new Vue({
    el: '#release_area',
    data: {
        tabIndex: 0,
        isDisabled: true,
        week_options: [
            { value: 0, text: "請選擇更新星期" },
            { value: 1, text: "星期一" },
            { value: 2, text: "星期二" },
            { value: 3, text: "星期三" },
            { value: 4, text: "星期四" },
            { value: 5, text: "星期五" },
            { value: 6, text: "星期六" },
            { value: 7, text: "星期日" }

        ],
        main_options: [
            { value: 0, text: "請選擇一個主標籤" },
            { value: 8, text: "奇幻" },
            { value: 10, text: "愛情" },
            { value: 9, text: "動作冒險" },
            { value: 11, text: "劇情" }
        ],
        one_options: [
            { value: 0, text: "可選擇副標籤" },
            { value: 3, text: "精采絕倫" },
            { value: 19, text: "奇幻愛情" },
            { value: 26, text: "專業" },
            { value: 5, text: "復仇" },
            { value: 20, text: "怦然心動" },
            { value: 2, text: "緊張刺激" },
            { value: 12, text: "懸疑恐怖" }
        ],
        two_options: [
            { value:0, text: "可選擇副標籤" },
            { value: 7, text: "淒美愛情" },
            { value: 14, text: "三角關係" },
            { value: 18, text: "刻劃細膩" },
            { value: 4, text: "揪心" },
            { value: 17, text: "改變命運" },
            { value: 1, text: "欲罷不能" },
            { value: 16, text: "成長" }

        ],
        three_options: [
            { value: 0, text: "可選擇副標籤" },
            { value: 15, text: "大格局" },
            { value: 24, text: "食指大動" },
            { value: 22, text: "津津有味" },
            { value: 28, text: "爆笑" },
            { value: 27, text: "職場生活" },
            { value: 25, text: "浪漫喜劇" },
            { value: 23, text: "活潑可愛" },
            { value: 6, text: "清新" }

        ],
        AuditEmployeeId: [
            { value:0, text: '請選出您的工號' },
            { value: 1, text: "1" },
            { value: 2, text: "2" },
            { value: 3, text: "3" },
            { value: 4, text: "4" },
            { value: 5, text: "5" }
        ],
        inputverify: {
            ComicChineseNameError: true,
            ComicChineseNameErrMsg: '不可為空',
            ComicEngilshNameError: true,
            ComicEngilshNameErrMsg: '不可為空',
            AuthorError: true,
            AuthorErrMsg: '不可為空',
            PainterError:true,
            PainterErrMsg: '不可為空',
            UpdateWeekError:true,
            UpdateWeekErrMsg: '不可為空',
            
            BgColorError:true,
            BgColorErrMsg: '不可為空',
            IntroductionError:true,
            IntroductionErrMsg: '不可為空',
            MainTagError:true,
            MainTagErrMsg: '不可為空',
            Comic_subtitleError:true,
            Comic_subtitleErrMsg: '不可為空',
            Comic_subtitle_twoError:true,
            Comic_subtitle_twoErrMsg: '不可為空',
            Comic_subtitle_threeError:true,
            Comic_subtitle_threeMsg: '不可為空',
            AuditEmployeeIdError:true,
            AuditEmployeeIdMsg: '不可為空'
        },
        comicData: {
            preview: {
                ComicWeekFigure: "",
                BgCover: "",
                ComicFigure: "",
                ComicNameImage: ""
            },
            createComicData: {

                ComicWeekFigure: "",
                BgCover: "",
                ComicFigure: "",
                ComicNameImage: "",
                ComicChineseName: "",
                ComicEnglishName: "",
                Author: "",
                Painter: "",
                UpdateWeek: 1,
                PublishDate: null,
                BgColor: "",
                Introduction: "",
                MainTag: "",
                Comic_subtitle: 0,
                Comic_subtitle_two: 0,
                Comic_subtitle_three: 0,
                AuditEmployeeId:0
            }
        }
    },
    methods: {
        linkClass(idx) {
            if (this.tabIndex === idx) {
                return ['bg-primary', 'text-light']
            } else {
                return ['bg-light', 'text-info']
            }
        },
        previewImage(e) {
            let originalFile = e.target.files[0]
            if (originalFile) {
                this.comicData.createComicData[e.target.id] = originalFile;
                let reader = new FileReader();
                reader.onload = (re) => {
                    console.log(re)
                    console.log(e)
                    this.imgSize(e, re)
                };
                reader.readAsDataURL(originalFile);

            }
        },
        imgSize(e, re) {
            console.log(e.target.id)
            if (e.target.id == "ComicWeekFigure") {
                console.log(re)
                console.log(e)

                let width = 248
                let height = 520
                this.sizeMethod(e, re, width, height)
            }
            else if (e.target.id == "BgCover") {
                let width = 375
                let height = 812
                this.sizeMethod(e, re, width, height)

            }
            else if (e.target.id == "ComicFigure") {
                let width = 710
                let height = 600
                this.sizeMethod(e, re, width, height)

            }
            else if (e.target.id == "ComicNameImage") {
                let width = 248
                let height = 180
                this.sizeMethod(e, re, width, height)

            }
        },
        sizeMethod(e, re, width, height) {
            console.log(re)
            console.log(e)
            console.log(width)
            console.log(height)

            let img = new Image();
            img.src = re.target.result
            let IsValid
            img.onload = function () {
                imgWidth = img.width;
                imgHight = img.height;
                IsValid = img.width == width && img.height == height;
                console.log(IsValid)
                //使用this有風險因為可能不知道是什麼
                console.log(release_area.comicData.preview[e.target.id])
                console.log(re.target.result)
                IsValid ? release_area.comicData.preview[e.target.id] = re.target.result : alert("尺寸不符")

            }
        },
        verify(name, value) {
            if (value || value!==0) {
                release_area.inputverify[`${name}Error`] = false;
                release_area.inputverify[`${name}ErrMsg`] = '';
                console.log("f")
            }
            else {
                release_area.inputverify[`${name}Error`] = true;
                release_area.inputverify[`${name}ErrMsg`] = '不可為空';
                console.log("t")

            }
        },
        checkinput() {
            let verifyList = Object.keys(this.inputverify);
            let value = []
            verifyList.forEach(key => {
                value.push(this.inputverify[key]);
            })
            if (value.includes(true)) {
                this.isDisabled = true;
                return
            }
            this.isDisabled = false;
        },
        createComic() {
            let formData = new FormData()
            let keyList = Object.keys(this.comicData.createComicData);

            let test = []

            keyList.forEach(key => {
                let value = this.comicData.createComicData[key];
                console.log(value)


                formData.append(`${key}`, this.comicData.createComicData[key]);


                test.push({ Key: `${key}`, data: this.comicData.createComicData[key] })
            })
            console.log(test)
            axios.post('/api/AdminUploadComicApi/AdminUploadComic',
                formData, {
                headers: {
                    'Content-Type': 'multipart/form-data'
                }
            })
            .then((res) => {
                console.log("成功")
            }).catch(e => {
                console.log("錯誤")
            })
            // axios.post('api/UploadComicApi/UploadComic', formData)
            //     .then((res) => {
            //         if (res.data.status == 20000) {
            //             toastr.success('新增成功')
            //             $('#create-modal').modal('hide')
            //         }
            //         else {
            //             toastr.error('新增失敗');
            //         }
            //         console.log(res)
            //     })
        }


    }
});


