    let bs = new Vue({
        el: '#app',
    data() {
            return {
        StatisticsInfo: [],
    TopComicTable: [],
    fields: [
    {key: 'topNum', label: '排名', class: 'text-center' ,sortable: true,Variant: 'info' },
    {key: 'comicChineseName', label: '漫畫名稱' },
    {key: 'clickRecordCount', label: '點擊數', class: 'text-center' }
    ],
    activityList:[],
    memberList:[],
    comicList:[]
            }
         },
    mounted(){
        this.getactivitySumData(),
        this.getmemberSumData(),
        this.getcomicSumData(),
        this.getrankingData()

    },
    methods: {
        getactivitySumData() {
        axios.get('/api/DashboardApi/GetActivityChart')
            .then(res => {
                this.activityList = res.data[0].activityCount;
                console.log(res.data[0].activityCount);
            });
             },
    getmemberSumData() {
        axios.get('/api/DashboardApi/GetMemberChart')
            .then(res => {
                this.memberList = res.data[0].memberCount;
                console.log(res.data[0].memberCount);
            });
             },
    getrankingData() {
        axios.get('/api/DashboardApi/GetRankChart')
            .then(res => {

                this.TopComicTable = res.data;
                console.log(this.TopComicTable);
            });
             },
    getcomicSumData() {
        axios.get('/api/DashboardApi/GetComicChart')
            .then(res => {
                this.comicList = res.data[0].comicCount;
                console.log(res.data[0].comicCount);
            });
             },
         }
    });
