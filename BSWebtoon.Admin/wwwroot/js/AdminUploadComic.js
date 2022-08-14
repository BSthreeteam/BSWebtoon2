
let release_area = new Vue({
    el: '#release_area',
    data: {
        tabIndex: 0,
        week_options: [
            { value: null, text: "請選擇更新星期" },
            { value: 1, text: "星期一" },
            { value: 2, text: "星期二" },
            { value: 3, text: "星期三" },
            { value: 4, text: "星期四" },
            { value: 5, text: "星期五" },
            { value: 6, text: "星期六" },
            { value: 7, text: "星期日" }

        ],
        main_options: [
            { value: null, text: "請選擇一個主標籤" },
            { value: "奇幻", text: "奇幻" },
            { value: "愛情", text: "愛情" },
            { value: "動作冒險", text: "動作冒險" },
            { value: "劇情", text: "劇情" }
        ],
        one_options: [
            { value: null, text: "可選擇副標籤" },
            { value: "精采絕倫", text: "精采絕倫" },
            { value: "奇幻愛情", text: "奇幻愛情" },
            { value: "專業", text: "專業" },
            { value: "復仇", text: "復仇" },
            { value: "怦然心動", text: "怦然心動" },
            { value: "緊張刺激", text: "緊張刺激" },
            { value: "懸疑推理", text: "懸疑推理" }
        ],
        two_options: [
            { value: null, text: "可選擇副標籤" },
            { value: "淒美愛情", text: "淒美愛情" },
            { value: "三角關係", text: "三角關係" },
            { value: "刻劃細膩", text: "刻劃細膩" },
            { value: "揪心", text: "揪心" },
            { value: "改變命運", text: "改變命運" },
            { value: "欲罷不能", text: "欲罷不能" },
            { value: "成長", text: "成長" }

        ],
        three_options: [
            { value: null, text: "可選擇副標籤" },
            { value: "大格局", text: "大格局" },
            { value: "食指大動", text: "食指大動" },
            { value: "津津有味", text: "津津有味" },
            { value: "爆笑", text: "爆笑" },
            { value: "職場生活", text: "職場生活" },
            { value: "浪漫喜劇", text: "浪漫喜劇" },
            { value: "活潑可愛", text: "活潑可愛" },
            { value: "清新", text: "清新" }

        ],
        AuditEmployeeId: [
            { value: null, text: '請選出您的工號' },
            { value: 1, text: "1" },
            { value: 2, text: "2" },
            { value: 3, text: "3" },
            { value: 4, text: "4" },
            { value: 5, text: "5" }
        ],
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
                ComicChineseName: "erty",
                ComicEnglishName: "ert",
                Author: "sdf",
                Painter: "er",
                UpdateWeek: 1,
                PublishDate: null,
                BgColor: "wert",
                Introduction: "wert",
                MainTag: "wertyj",
                Comic_subtitle: null,
                Comic_subtitle_two: null,
                Comic_subtitle_three: null,
                AuditEmployeeId: null
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
            console.log(e.target.files)
            if (originalFile) {
                console.log(e.target.id)
                console.log(this.comicData.preview[e.target.id])
                this.comicData.createComicData[e.target.id] = originalFile;
                let reader = new FileReader();
                reader.onload = (re) => {
                    console.log(re)
                    console.log(e.target.id)
                    this.comicData.preview[e.target.id] = re.target.result
                };
                reader.readAsDataURL(originalFile);

            }
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
            }).then((res) => {
                console.log(res)
            }).catch(e => {
                console.log(e)
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
    },
});


