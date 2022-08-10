//����ɶ��榡��
function DateFormat(value, format) {
    return moment(value).format('YYYY/MM/DD');
}
//����榡��
Vue.filter('DateString', function (value, format) {
    return moment(value).format('YYYY/MM/DD')
});
let app = new Vue({
    el: '#app',
    data: {
        selected: [],//���A�ݨ�A�Ŀ�ﶵ��value 
        fields: [
            { key: 'memberId', label: "�|���s��", sortable: true },
            { key: 'accountName', label: "�|���b��W��", sortable: true },
            { key: 'nickName', label: "�@�̩m�W", sortable: true },
            { key: 'balance', label: "�b��l�B", sortable: true },
            { key: 'loginTypeName', label: "�n���覡", sortable: true, filterByFormatted: true },
            { key: 'email', label: "�|���H�c", sortable: true },
            { key: 'Action', label: '�\��' },
        ],
        items: [
            { key: 'Google', label: "Google", sortable: true },
            { key: 'Line', label: 'Line', sortable: true },
            { key: 'Facebook', label: 'Facebook', sortable: true }
        ],
        memberList: [],
        filterOn: [],
        currentPage: 1,
        //�@���X�����
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
                    this.memberList = res.data
                    console.log(this.memberList);
                    if (res.status == 200) {
                        this.memberList = res.data;
                    }
                    else {
                        alert('�W�Ǥ����\')
                    }
                })
        },
        onFiltered(filteredItems) {
            this.totalRows = filteredItems.length
            this.currentPage = 1
        }
    }

})