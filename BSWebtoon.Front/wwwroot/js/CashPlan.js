let btn_next = document.getElementById('btn_next');
window.onload = function () {
    btn_next.onclick = () => {
        let plan = document.querySelector('[name=cashplan]:checked');
        getans(plan.value)
    }

}


function getans(type) {
    console.log(type)
    fetch('/Recharge/CashPlan', {
        method: 'POST',
        cache: 'no-cache',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({ CashPlanId: type })
    }).then(res => {
        if (res.ok) return res.json(); // 使用 json() 可以得到 json 物件 
    })
        .then(res => {
            console.log(res);
        })


}