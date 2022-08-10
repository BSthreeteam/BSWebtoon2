//日期時間格式化
function DateFormat(value, format) {
    return moment(value).format(format || 'YYYY/MM/DD');
}
//日期格式化
Vue.filter('DateString', function (value, format) {
    return moment(value).format(format || 'YYYY/MM/DD')
});
let app = new Vue({
    el: '#app',
    data: {
        selected: [],//給你看到你勾選選項的value
        fields: ['employeeId', 'employeeName', 'hireDate', 'account'],//可以放欄位名稱
        employeeList: [],
        perPage: 5,
        currentPage: 1,
        pageOptions: [5, 10, 15, 20],
        filter: '',
    },
    mounted() {
        this.getAllEmployee();
    },
    methods: {
        getAllEmployee() {
            axios.get('/api/EmployeeApi/management')
                .then((res) => {
                    console.log('ok');
                    if (res.status == 200) {
                        this.employeeList = res.data.map((item) => {
                            return {
                                employeeId: item.employeeId,
                                employeeName: item.employeeName,
                                hireDate: DateFormat(item.hireDate),
                                account: item.account
                            }
                        })
                        console.log(this.employeeList);
                    } else {
                        alert('你失敗了')
                    }
                })
        }
    },
    computed: {
        totalRows() {
            return this.employeeList.length;
        }
    },

}