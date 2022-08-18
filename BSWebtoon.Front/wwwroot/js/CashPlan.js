let btn_next = document.getElementById('btn_next');
window.onload = function () {
    const app = Vue.createApp({
        methods: {
            // 傳送至藍新金流
            SendToNewebPay(ChannelID) {
                var self = this;
                let plan = document.querySelector('[name=cashplan]:checked').value;
                // 組合表單資料
                var postData = {};
                postData['ChannelID'] = ChannelID;
                postData['ItemDesc'] = plan;//到後端用id找
                // 使用 jQuery Ajax 傳送至後端
                $.ajax({
                    url: newebPayUrl,
                    method: 'POST',
                    dataType: 'json',
                    data: { inModel: postData, __RequestVerificationToken: antiForgeryToken },
                    success: function (returnObj) {
                        // 呼叫藍新金流 API
                        const form = document.createElement('form');
                        form.method = 'post';
                        form.action = 'https://ccore.newebpay.com/MPG/mpg_gateway';//藍新金流驗證網址(測試環境)
                        for (const key in returnObj) {
                            if (returnObj.hasOwnProperty(key)) {
                                const hiddenField = document.createElement('input');
                                hiddenField.type = 'hidden';
                                hiddenField.name = key;
                                hiddenField.value = returnObj[key];
                                form.appendChild(hiddenField);
                            }
                        }
                        document.body.appendChild(form);
                        form.submit();
                    },
                    error: function (err) {
                        alert(err.status + " " + err.statusText + '\n' + err.responseText);
                    }
                });
            }
        }
    });
    const vm = app.mount('#app');
}