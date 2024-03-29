let getUniversalCouponBtn = document.querySelector('.getUniversalCouponBtn')
async function clickGetCouponBtn(ActivityId, universalCouponGetCount, couponTypeId, memberId) {
    if (isAuthenticated) {
        var couponData = {
            "ActivityId": ActivityId,
            "OriginQuantity": universalCouponGetCount,
            "CouponTypeId": couponTypeId,
            "MemberId": memberId
        }
        await fetch("/api/CouponApi/ActivityCoupon", {
            method: "POST",
            headers: {
                "Accept": "application/json",
                "Content-type": "application/json"
            },
            body: JSON.stringify(couponData)
        })
            .then(response => response.text())
            .then(result => {
                if (result.ok) {
                    console.log(result)
                }
            })
            .catch(ex => {
                console.log(ex)
            })
        getUniversalCouponBtn.disabled = true
    } else {
        $('#exampleModal').modal('show');
        getUniversalCouponBtn.disabled = false
    }
}
