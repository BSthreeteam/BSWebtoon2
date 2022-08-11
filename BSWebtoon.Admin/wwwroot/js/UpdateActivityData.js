
const app = new Vue({
    el: '#app',
    data: {
        ActivityList: [],
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
                    if (res.data.status === 200) {
                    }
                })
        },
    },
})
