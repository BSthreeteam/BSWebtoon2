let recordItem_a = document.querySelectorAll('.recordItem_a')
let nothing = document.querySelector('.nothing')
let recordTable = document.querySelector('.recordTable')
let recordTableNav = document.querySelector('.recordTableNav')
let coinRecord = document.querySelector('.coinRecord')
let tableContent = document.querySelector('#tableContent')

window.onload = function () {
    //coinRecord.onclick = GetCoinDetails(member)
}

let tableTemplate = document.getElementById('tableTemplate')
recordItem_a.forEach(item => {
    item.addEventListener('click', (e) => {
        let group = document.querySelectorAll('.recordItem_a')
        group.forEach(groupItem => {
            groupItem.classList.remove('selectedRecordItem')
        })
        item.classList.add('selectedRecordItem')
        //nothing.classList.add('d-none')
        //recordTable.classList.remove('d-none')
        //captionText.innerHTML = item.innerHTML
        //recordTableNav.classList.remove('d-none')
    })
})
function GetCoinDetails(memberId) {
    tableContent.innerHTML = ""
    fetch(`/api/GetAccountRecord/GetCoinDetails/${memberId}`)
        .then(response => { return response.json() })
        .then(result => {
            //console.log(result)
            if (result != null) {
                nothing.classList.add('d-none')
            }
            tableContent.appendChild(GetCloneTable(result))
        })
        .catch(ex => {
            console.log(ex)
        })
}
function GetCloneTable(resultObj) {
    let CloneTable = tableTemplate.content.cloneNode(true);
    //let captionText = CloneTable.querySelector('.captionText')
    let caption = document.createElement('caption');
    //caption.classList.add("captionText")
    caption.innerHTML = coinRecord.innerHTML
    CloneTable.appendChild(caption);

    //thead
    let thead = document.createElement('thead');
    CloneTable.appendChild(thead);

    //tbody
    let tbody = document.createElement('tbody');
    CloneTable.appendChild(tbody);
    console.log(resultObj.coinDetailList)
    for (let i = 0; i < resultObj.coinDetailList.length; i++) {
        let array = Object.keys(resultObj.coinDetailList[i])
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
        for (let j = 0; j < Object.values(resultObj.coinDetailList[i]).length; j++) {
            let td = document.createElement('td');
            //console.log(Object.values(resultObj.coinDetailList[i])[j])

            td.innerText = Object.values(resultObj.coinDetailList[i])[j];
            tr.appendChild(td);
        }
    }

    return CloneTable;
}