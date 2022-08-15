
const app = new Vue({
    el: '#app',
    data: {
        ActivityList: [],
        //編輯
        currentActivity: {},
    },
    mounted() {
        this.getAllActivityList()
    },
    methods: {
        getAllActivityList() {
            axios.get('/api/UpdateActivityApi/Read')
                .then((res) => {
                    
                        console.log(res)
                        this.ActivityList = res.data
                    
                })
        },
        selectEdit(Activity) {
            
            this.currentActivity = { ...Activity}
        },
        updateActivity() {
            axios({
                method: 'put',
                url: '/api/UpdateActivityApi/Update',
                data: this.currentActivity
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
