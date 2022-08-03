let getUniversalCouponBtn = document.querySelector('.getUniversalCouponBtn')
async function clickGetCouponBtn(ActivityId, universalCouponGetCount, couponTypeId, memberId) {
    if (isAuthenticated) {
        var couponData = {
            "ActivityId": ActivityId,
            "OriginQuantity": universalCouponGetCount,
            "CreateTime": new Date(),
            "CouponTypeId": couponTypeId,
            "MemberId": memberId
        }
        await fetch("/api/Coupon/ActivityCoupon", {
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
    } else {
        $('#exampleModal').modal('show');
    }
    getUniversalCouponBtn.disabled = true
}
