//����ɶ��榡��
function DateFormat(value, format) {
    return moment(value).format(format || 'YYYY/MM/DD');
}
//����榡��
Vue.filter('DateString', function (value, format) {
    return moment(value).format(format || 'YYYY/MM/DD')
});
let app = new Vue({
    el: '#app',
    data: {
        selected: [],//���A�ݨ�A�Ŀ�ﶵ��value
        fields: ['employeeId', 'employeeName', 'hireDate', 'account'],//�i�H�����W��
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
                        alert('�A���ѤF')
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