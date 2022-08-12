let recordItem_a = document.querySelectorAll('.recordItem_a')
let nothing = document.querySelector('.nothing')
let nothing_text = document.querySelector('.nothing_text')
let coinRecord = document.querySelector('.coinRecord')
let couponRecord = document.querySelector('.couponRecord')
let tableTemplate = document.getElementById('tableTemplate')
let tableOld = document.getElementById('tableOld')
let CouponData = []
let CoinData = []

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
    tableOld.innerHTML = ""
    CouponData = []
    fetch(`/api/GetAccountRecordApi/GetCouponDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            if (result != null) {
                nothing.classList.add('d-none')
                tableOld.appendChild(GetCloneTable(result.CouponDetailList, couponRecord.innerHTML))
                CouponData.push(result.CouponDetailList)
                console.log(CouponData)
                $('#tableCoupon').bootstrapTable({ data: CouponData })
            }
        })
        .catch(ex => {
            console.log(ex)
        })
}

function GetCoinDetails(memberId) {
    tableOld.innerHTML = ""
    CoinData = []
    fetch(`/api/GetAccountRecordApi/GetCoinDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            if (result != null) {
                nothing.classList.add('d-none')
                tableOld.appendChild(GetCloneTable(result.coinDetailList, coinRecord.innerHTML))
                CoinData.push(result.coinDetailList)
                console.log(CoinData)
                $('#tableCoin').bootstrapTable({ data: CoinData })
            }
        })
        .catch(ex => {
            console.log(ex)
        })
}

function GetCloneTable(resultObj, captionText) {
    let CloneTable = tableTemplate.content.cloneNode(true);
    let caption = document.createElement('caption');
    caption.innerHTML = captionText
    CloneTable.appendChild(caption);

    //thead
    let thead = document.createElement('thead');
    CloneTable.appendChild(thead);

    //tbody
    let tbody = document.createElement('tbody');
    CloneTable.appendChild(tbody);
    for (let i = 0; i < resultObj.length; i++) {
        let array = Object.keys(resultObj[i])
        if (array[i] != undefined) {
            array += array[i]
        }
        let tr = document.createElement('tr')
        if (i == 0) {
            thead.appendChild(tr);
        } else {
            tbody.appendChild(tr);
        }
        for (let j = 0; j < Object.values(resultObj[i]).length; j++) {
            let td = document.createElement('td');
            td.innerText = Object.values(resultObj[i])[j];
            tr.appendChild(td);
        }
    }
    return CloneTable;
}


$(function () {
    couponRecord.onclick = GetCoinDetails(member)
})

