//日期時間格式化
function DateFormat(value, format) {
    return moment(value).format('YYYY/MM/DD');
}
//日期格式化
Vue.filter('DateString', function (value, format) {
    return moment(value).format('YYYY/MM/DD')
});
let app = new Vue({
    el: '#app',
    data: {
        selected: [],//給你看到你勾選選項的value 
        fields: [
            { key: 'memberId', label: "會員編號", sortable: true },
            { key: 'accountName', label: "會員帳戶名稱", sortable: true },
            { key: 'nickName', label: "作者姓名", sortable: true },
            { key: 'balance', label: "帳戶餘額", sortable: true },
            { key: 'loginTypeName', label:"登錄方式", sortable: true, filterByFormatted: true },
            { key: 'email', label:"會員信箱", sortable: true },
            { key: 'Action', label: '功能' },
        ],
        fieldss: [ 'memberId', 'accountName', 'nickName', 'balance', 'loginTypeName', 'email', 'Action'],
        memberList: [],
        filterOn: [],
        currentPage: 1,
        //一頁幾筆資料
        perPage: 10,
        filter: '',
        pageOptions: [5, 10, 25, 100],
        sortBy: '',
        sortDesc: false,
        sortDirection: 'asc'
    },
    computed: {
        totalRows() {
            return this.memberList.length
        }
    },
    mounted() {
        this.getAllMember()
    },
    methods: {
        getAllMember() {
            axios.get('/api/MemberApi/Index')
                .then((res) => {
                    console.log(res.data);
                    this.memberList = res.data;
                })
        },
        onFiltered(filteredItems) {
            this.totalRows = filteredItems.length
            this.currentPage = 1
        }
    }

})