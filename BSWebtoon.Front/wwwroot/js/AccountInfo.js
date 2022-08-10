let recordItem_a = document.querySelectorAll('.recordItem_a')
let nothing = document.querySelector('.nothing')
let nothing_text = document.querySelector('.nothing_text')
let recordTable = document.querySelector('.recordTable')
let recordTableNav = document.querySelector('.recordTableNav')
let coinRecord = document.querySelector('.coinRecord')
let couponRecord = document.querySelector('.couponRecord')
let tableContent = document.querySelector('#tableContent')

window.onload = function () {
    couponRecord.onclick = GetCouponDetails(member)
}

let tableTemplate = document.getElementById('tableTemplate')
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
    tableContent.innerHTML = ""
    fetch(`/api/GetAccountRecordApi/GetCouponDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            //console.log(result)
            if (result != null) {
                nothing.classList.add('d-none')
                tableContent.appendChild(GetCloneTable(result.CouponDetailList, couponRecord.innerHTML))
            }
        })
        .catch(ex => {
            console.log(ex)
        })
}

function GetCoinDetails(memberId) {
    tableContent.innerHTML = ""
    fetch(`/api/GetAccountRecordApi/GetCoinDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            //console.log(result)
            if (result != null) {
                nothing.classList.add('d-none')
                tableContent.appendChild(GetCloneTable(result.coinDetailList, coinRecord.innerHTML))
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
    console.log(resultObj)
    for (let i = 0; i < resultObj.length; i++) {
        let array = Object.keys(resultObj[i])
        if (array[i] != undefined) {
            array += array[i]
            console.log(array)
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