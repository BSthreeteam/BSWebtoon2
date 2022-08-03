
window.onload = function () {
    let readYet = document.querySelector('.readYet');
    let buyOneTime = document.querySelector('.buyOneTime');
    let nowHaveCoupon = document.querySelector('.nowHaveCoupon');

    let nowHaveCouponQuantity = nowHaveCoupon.innerHTML.slice(0, nowHaveCoupon.innerHTML.length - 1)
    let readYetQuantity = readYet.innerHTML.slice(0, readYet.innerHTML.length - 1)
    buyOneTime.innerHTML = `${readYetQuantity - nowHaveCouponQuantity}張`

    let totalAmount = document.querySelector('.totalAmount')
    let planQuantity = document.querySelector('.planQuantity')
    let totalQuantity = document.querySelector('.totalQuantity')

    let quantity_minus_btn = document.querySelector('.quantity_minus')
    let quantity_plus_btn = document.querySelector('.quantity_plus')
    let buyQuantity = document.querySelector('.buyQuantity')

    let buyCoupon_buy = document.querySelector('.buyCoupon_buy')

    let buyCoupon_plan_listItem = document.querySelectorAll('.buyCoupon_plan_listItem')
    let buyOneTime_btn = document.querySelector('.buyOneTime_btn')
    buyOneTime_btn.innerHTML = `<img src="data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMTgiIGhlaWdodD0iMTgiIHZpZXdCb3g9IjAgMCAxOCAxOCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4KICAgIDxnIGZpbGw9IiNGRkYiIGZpbGwtcnVsZT0ibm9uemVybyI+CiAgICAgICAgPHBhdGggZD0ibTkgMCA3Ljg3NSA0LjV2OUw5IDE4bC03Ljg3NS00LjV2LTlMOSAwem0wIDEuOTQzTDIuODEyIDUuNDc5djcuMDQxTDkgMTYuMDU2bDYuMTg4LTMuNTM3di03LjA0TDkgMS45NDR6Ii8+CiAgICAgICAgPHBhdGggZD0ibTkuMDAyIDQuNjUgMy43NjcgMi4xNzUtMS42ODcuOTczTDkuMDA0IDYuNiA2LjkyMiA3Ljh2Mi40MDRsMi4wOCAxLjIgMi4wOC0xLjIgMS42ODguOTc0LTMuNzY4IDIuMTc2LTMuNzY5LTIuMTc2VjYuODI3eiIvPgogICAgPC9nPgo8L3N2Zz4K"
                            alt="">${parseInt(buyOneTime.innerHTML) * 300}`

    buyCoupon_plan_listItem.forEach(item => {
        let btn = item.querySelector('.buyCoupon_plan_btn')
        btn.addEventListener('click', () => {
            quantity_minus_btn.style.display = "inline-block"
            quantity_plus_btn.style.display = "inline-block"
            buyQuantity.style.display = "inline-block"

            let btnAmount = btn.innerText.trim()
            totalAmount.innerText = btnAmount
            let itemList = item.innerText.split('\n')
            let resultItem = itemList.slice(itemList.length - 2, itemList.length - 1)
            planQuantity.innerText = resultItem
            totalQuantity.innerText = resultItem
            CountAmount(buyQuantity)
        })
    })

    buyOneTime_btn.addEventListener('click', () => {
        quantity_minus_btn.style.display = "none"
        quantity_plus_btn.style.display = "none"
        buyQuantity.style.display = "none"
        planQuantity.innerText = buyOneTime.innerHTML
        totalQuantity.innerText = buyOneTime.innerHTML
        totalAmount.innerHTML = readYetQuantity * 300
    })

    //數量加減
    quantity_minus_btn.addEventListener('click', () => {
        let buyQuantityInt = parseInt(buyQuantity.innerText)
        if (buyQuantityInt <= 1) {
            buyQuantityInt = 1
        } else {
            buyQuantity.innerText = buyQuantityInt - 1
        }
        CountAmount(buyQuantity)
    })
    quantity_plus_btn.addEventListener('click', () => {
        let buyQuantityInt = parseInt(buyQuantity.innerText)
        buyQuantity.innerText = buyQuantityInt + 1
        CountAmount(buyQuantity)
    })
    function CountAmount(buyQuantity) {
        let totalQuantity = document.querySelector('.totalQuantity')
        let buyQuantityInt = parseInt(buyQuantity.innerText)
        let planQuantityInt = parseInt(planQuantity.innerText.slice(0, planQuantity.innerText.length - 1))
        totalQuantity.innerHTML = ${ buyQuantityInt * planQuantityInt } 張
        totalAmount.innerHTML = buyQuantityInt * planQuantityInt * 300
    }

    function BuyReadCoupon(ComicId, couponTypeId, memberId) {
        let totalQuantity = document.querySelector('.totalQuantity')
        let buyQuantity = totalQuantity.innerHTML.slice(0, totalQuantity.innerHTML.length - 1)
        if (MemberHaveCoin < totalAmount.innerHTML) {
            alert('金幣餘額不足，將自動導向儲值頁面')
            window.location.href = `/Recharge/CashPlanView`;
        }
        else {
            var couponData = {
                "ComicId": ComicId,
                "OriginQuantity": buyQuantity,
                "CreateTime": new Date(),
                "CouponTypeId": couponTypeId,
                "MemberId": memberId
            }
            fetch("/api/Coupon/ReadCoupon")
        }
    }
}

