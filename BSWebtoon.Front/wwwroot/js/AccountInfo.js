let recordItem_a = document.querySelectorAll('.recordItem_a')
let nothing = document.querySelector('.nothing')
let nothing_text = document.querySelector('.nothing_text')
let coinRecord = document.querySelector('.coinRecord')
let couponRecord = document.querySelector('.couponRecord')
//let CouponData = []
//let CoinData = []

recordItem_a.forEach(item => {
    item.addEventListener('click', (e) => {
        let group = document.querySelectorAll('.recordItem_a')
        group.forEach(groupItem => {
            groupItem.classList.remove('selectedRecordItem')
        })
        item.classList.add('selectedRecordItem')
    })
})
function GetCouponDetails(memberId) {
    CouponData = []
    fetch(`/api/GetAccountRecordApi/GetCouponDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            if (result != null) {
                nothing.classList.add('d-none')
                //CouponData.push(result.CouponDetailList)
                GetCouponBootstrapTable(result.CouponDetailList)
            }
        })
        .catch(ex => {
            console.log(ex)
        })
}

function GetCoinDetails(memberId) {
    CoinData = []
    fetch(`/api/GetAccountRecordApi/GetCoinDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            if (result != null) {
                nothing.classList.add('d-none')
                //CoinData.push(result.coinDetailList)
                GetCoinBootstrapTable(result.coinDetailList)
            }
        })
        .catch(ex => {
            console.log(ex)
        })
}

//function GetCloneTable(resultObj, captionText) {
//    let CloneTable = tableTemplate.content.cloneNode(true);
//    let caption = document.createElement('caption');
//    caption.innerHTML = captionText
//    CloneTable.appendChild(caption);

//    //thead
//    let thead = document.createElement('thead');
//    CloneTable.appendChild(thead);

//    //tbody
//    let tbody = document.createElement('tbody');
//    CloneTable.appendChild(tbody);
//    for (let i = 0; i < resultObj.length; i++) {
//        let array = Object.keys(resultObj[i])
//        if (array[i] != undefined) {
//            array += array[i]
//        }
//        let tr = document.createElement('tr')
//        if (i == 0) {
//            thead.appendChild(tr);
//        } else {
//            tbody.appendChild(tr);
//        }
//        for (let j = 0; j < Object.values(resultObj[i]).length; j++) {
//            let td = document.createElement('td');
//            td.innerText = Object.values(resultObj[i])[j];
//            tr.appendChild(td);
//        }
//    }
//    return CloneTable;
//}


function GetCoinBootstrapTable(data) {
    console.log(data)
    $("#tableCoin").bootstrapTable('destroy');
    $("#tableCoupon").bootstrapTable('destroy');
    $('#tableCoin').bootstrapTable({
        data: data,
        pagination: true,
        pageSize: 10, //每頁顯示條數
        pageList: [5, 10, 15, 20, 25],
        columns: [{
            field: 'ConsumptionOrRecharge',
            title: '儲值/消費'
        }, {
            field: 'CoinContent',
            title: '金幣金額'
        }, {
            field: 'CreateTime',
            title: '時間'
        }, {
            field: 'ComicName',
            title: '漫畫名稱'
        }]
    })
}

function GetCouponBootstrapTable(data) {
    console.log(data)
    $("#tableCoin").bootstrapTable('destroy');
    $("#tableCoupon").bootstrapTable('destroy');
    $('#tableCoupon').bootstrapTable({
        data: data,
        pagination: true,
        pageSize: 10, //每頁顯示條數
        pageList: [5, 10, 15, 20, 25],
        columns: [{
            field: 'BuyOrUse',
            title: '獲得/使用',
        }, {
            field: 'CouponType',
            title: '券種',
        }, {
            field: 'BuyOrUseCount',
            title: '獲得/使用數量',
        }, {
            field: 'CreateTime',
            title: '時間',
            sortable: true
        }, {
            field: 'ComicName',
            title: '漫畫名稱',
        }, {
            field: 'ActivityName',
            title: '活動名稱',
        }]
    })
}

$(function () {
    couponRecord.onclick =  GetCouponDetails(member) 
})
