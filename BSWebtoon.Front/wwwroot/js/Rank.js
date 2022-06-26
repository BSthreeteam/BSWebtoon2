let jsdata = [];
const url = "https://raw.githubusercontent.com/Ankepoyou/FileStorage/main/comics";
let xhr = new XMLHttpRequest();
xhr.onload = function () {
    jsdata = JSON.parse(xhr.responseText);
    console.log(jsdata);
    document.getElementsByClassName("all_a")[0].click();
}
xhr.open("GET", url);
xhr.send();
let cardTemplate = document.querySelector('#cardTemplate');
let cardTemplate_up = document.querySelector('#cardTemplate_up');
let new_spen;

window.onload = function () {
    let fantasy, fantasy_love, action_adventure, love, plot, BL_GL;
    let all;

    let card_up_row, card_up, text, card_up_ranking, card_up_ranking_number;
    //宣告第一列 背景 , 影片或 封面
    let short_pic_up_bgc, short_pic_cover_up_video, short_pic_cover_up_video_source, short_pic_cover_up_cover;

    //宣告下面卡牌
    let row_down;

    // 連結區
    all = document.querySelector(".all")
    fantasy = document.querySelector(".fantasy")
    fantasy_love = document.querySelector(".fantasy_love")
    action_adventure = document.querySelector(".action_adventure")
    love = document.querySelector(".love")
    plot = document.querySelector(".plot")
    BL_GL = document.querySelector(".BL_GL")
    Suspenseful_horror = document.querySelector(".Suspenseful_horror")

    //<!-- 第一列 -->
    card_up_row = document.querySelector(".card_up_row")
    //<!-- 第一列圖片區 -->
    card_up = document.querySelector(".card_up")
    short_pic_up_bgc = document.querySelector("#short_pic_up_bgc")
    short_pic_cover_up_cover = document.querySelector("#short_pic_cover_up_cover")
    //<!-- 第一列影片區 -->
    short_pic_cover_up_video = document.querySelector("#short_pic_cover_up_video")
    short_pic_cover_up_video_source = document.querySelector("#short_pic_cover_up_video_source")
    //<!-- 第一列文字區 -->
    text = document.querySelector(".text")
    card_up_spen = document.querySelector(".card_up_spen")
    card_up_p_tital = document.querySelector(".card_up_p_tital")
    card_up_p = document.querySelector(".card_up_p")
    //<!-- 第一列排行區 -->
    card_up_ranking = document.querySelector(".card_up_ranking")
    card_up_ranking_number = document.querySelector(".card_up_ranking_number")





    // ------------------------------------------------------產卡片
    let cardTemplate;
    //創一個div節點
    row_down = document.querySelector(".row_down")

    //在div標籤，設定一個class屬性叫 row，再到上面的css處理
    // row.setAttribute("class", "row");

    console.log(jsdata)
    // card_up_row.innerText = "";
    row_down.innerText = "";
    jsdata.forEach(Leaderboard_data => {
        row_down.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
        // document.body.append(row);
    });

    all.addEventListener("click", function () {

        // short_pic_cover_up_cover.style.display = "block";

        card_up_row.innerText = "";
        row_down.innerText = "";


        let bg = "https://tw-a.kakaopagecdn.com/P/C/252/bg/2x/17be08a2-b561-48e4-b624-e4c9511d4bdf.webp"

        let cvr = "https://tw-a.kakaopagecdn.com/P/C/252/c1/2x/1f23891d-6650-4512-b59b-fd908c3578de.webp"

        new_spen = "新作";

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";
        console.log(new_spen)

        card_up_row.append(getCard_up2(bg, cvr, new_spen, tital, new_p, new_number))

        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")
        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)
        jsdata.forEach(Leaderboard_data => {

            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });


    fantasy.addEventListener("click", function () {

        // short_pic_cover_up_cover.style.display = "none";
        // short_pic_cover_up_video.remove(short_pic_cover_up_video)
        card_up_row.innerText = "";

        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "none";
        // short_pic_cover_up_video.style.display = "block";

        let bg = "https://tw-a.kakaopagecdn.com/P/C/148/bg/2x/f485a521-3410-48a7-a3de-793514f1237c.jpg"

        let vi = "https://tw-a.kakaopagecdn.com/P/C/148/c1a/f1cb946f-cf65-4cbc-8a86-f03a1b929d39.webm"

        let card_up_spen = "新作"

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";


        card_up_row.append(getCard_up(bg, vi, new_spen, tital, new_p, new_number))



        // let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

        // window.addEventListener('resize', () => {

        //     var screenWidth = window.screen.width;
        //     if (screenWidth < 768) {
        //         short_pic_cover_up_video.style.display = "none";
        //     }
        //     else {
        //         short_pic_cover_up_video.style.display = "block";
        //     }

        // })

    });


    fantasy_love.addEventListener("click", function () {
        // short_pic_cover_up_video.style.display = "none";
        card_up_row.innerText = "";
        row_down.innerText = "";
        // short_pic_cover_up_cover.style.display = "block";

        let bg = "https://tw-a.kakaopagecdn.com/P/C/83/bg/2x/bfd6d1d2-da14-4310-9c40-b8cdb1365acd.jpg"

        let cvr = "https://tw-a.kakaopagecdn.com/P/C/83/c1/2x/47db6613-d920-4809-b8c3-3dc81c13572c.webp"

        new_spen = "新作";

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";
        console.log(new_spen)

        card_up_row.append(getCard_up2(bg, cvr, new_spen, tital, new_p, new_number))

        // //背景區
        // short_pic_up_bgc.src = "https://tw-a.kakaopagecdn.com/P/C/83/bg/2x/bfd6d1d2-da14-4310-9c40-b8cdb1365acd.jpg";
        // card_up.append(short_pic_up_bgc)
        // card_up_row.append(card_up);

        // //封面區
        // short_pic_cover_up_cover.src = "https://tw-a.kakaopagecdn.com/P/C/83/c1/2x/47db6613-d920-4809-b8c3-3dc81c13572c.webp";
        // card_up.append(short_pic_cover_up_cover)
        // card_up_row.append(card_up);

        // //文字區1-1
        // card_up_spen.innerText = "新作";
        // text.append(card_up_spen);
        // card_up_row.append(text);

        // //文字區1-2
        // card_up_p_tital.innerText = "綠蔭之冠";
        // text.append(card_up_p_tital);
        // card_up_row.append(text);

        // //文字區1-3
        // card_up_p.innerText = "戴上家族戒指——青炎弟弟的幸福，由我來守護!";
        // text.append(card_up_p);
        // card_up_row.append(text);

        // //排行區
        // card_up_ranking_number.innerText = "1";
        // card_up_ranking.append(card_up_ranking_number);
        // card_up_row.append(card_up_ranking);

        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");
        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });
    });

    action_adventure.addEventListener("click", function () {

        card_up_row.innerText = "";
        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "block";

        card_up_row.innerText = "";
        row_down.innerText = "";


        let bg = "https://tw-a.kakaopagecdn.com/P/C/252/bg/2x/17be08a2-b561-48e4-b624-e4c9511d4bdf.webp"

        let cvr = "https://tw-a.kakaopagecdn.com/P/C/252/c1/2x/1f23891d-6650-4512-b59b-fd908c3578de.webp"

        new_spen = "新作";

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";
        console.log(new_spen)

        card_up_row.append(getCard_up2(bg, cvr, new_spen, tital, new_p, new_number))


        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });


    love.addEventListener("click", function () {

        card_up_row.innerText = "";
        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "none";

        let bg = "https://tw-a.kakaopagecdn.com/P/C/23/bg/2x/9dd24af0-51e8-4d78-bb1a-7ed374a73c01.jpg"

        let vi = "https://tw-a.kakaopagecdn.com/P/C/23/c1a/c8ecc423-4e4b-4935-96d4-6dfbf8173c68.webm"

        let card_up_spen = "新作"

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";


        card_up_row.append(getCard_up(bg, vi, new_spen, tital, new_p, new_number))


        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });

    plot.addEventListener("click", function () {

        card_up_row.innerText = "";
        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "none";


        let bg = "https://tw-a.kakaopagecdn.com/P/C/223/bg/2x/b7dd7a28-ce3e-4f52-909e-3cdb3e5c8ac7.jpg"

        let vi = "https://tw-a.kakaopagecdn.com/P/C/223/c1a/46d37ca0-7e30-40e5-81bc-996dbac28d49.webm"

        let card_up_spen = "新作"

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";


        card_up_row.append(getCard_up(bg, vi, new_spen, tital, new_p, new_number))


        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });

    BL_GL.addEventListener("click", function () {

        card_up_row.innerText = "";
        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "none";

        let bg = "https://tw-a.kakaopagecdn.com/P/C/22/bg/2x/b1c402b3-24b3-419f-8239-2a3c994ece6a.jpg"

        let vi = "https://tw-a.kakaopagecdn.com/P/C/22/c1a/c493e0d5-6dda-4299-8301-dbf64eca26bb.webm"

        let card_up_spen = "新作"

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";


        card_up_row.append(getCard_up(bg, vi, new_spen, tital, new_p, new_number))

        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });


    Suspenseful_horror.addEventListener("click", function () {

        card_up_row.innerText = "";
        row_down.innerText = "";

        // short_pic_cover_up_cover.style.display = "none";

        let bg = "https://tw-a.kakaopagecdn.com/P/C/4/bg/2x/0a154bec-5501-4960-9eb3-a9aa78cb7750.jpg"

        let vi = "https://tw-a.kakaopagecdn.com/P/C/4/c1a/be863593-d8a5-4e17-82f2-3b3806b4010d.webm"

        let card_up_spen = "新作"

        let tital = "從新使用\n說明書";

        let new_p = "當最爛能力值遇上最殘酷的生存遊戲\n用特殊能力當個強人寄生蟲才是王道";

        let new_number = "1";


        card_up_row.append(getCard_up(bg, vi, new_spen, tital, new_p, new_number))



        let row, cardTemplate;
        //創一個div節點
        row = document.querySelector(".row_down")

        //在div標籤，設定一個class屬性叫 row，再到上面的css處理
        // row.setAttribute("class", "row");

        console.log(jsdata)

        // card_up_row.innerText = "";
        row_down.innerText = "";
        jsdata.forEach(Leaderboard_data => {
            row.append(getCard(Leaderboard_data.id, Leaderboard_data.workbackground, Leaderboard_data.workPrice, Leaderboard_data.workName));
            // document.body.append(row);
        });

    });
    document.getElementsByClassName("all_a")[0].click();
    // document.getElementsByClassName("all_a")[0].click();
}


function getCard(id, background, price, name) {
    let cloneCard = cardTemplate.content.cloneNode(true);
    let int_id = parseInt(id);

    cloneCard.querySelector(".short_down_span").innerText = eval(int_id)
    cloneCard.querySelector(".short_pic").src = background
    cloneCard.querySelector(".short_pic_cover").src = price
    cloneCard.querySelector(".short_down_p").innerText = name
    return cloneCard;
}
function getCard_up(background, _video, card_up_spen, tital, new_p, new_number) {
    let cloneCard = cardTemplate_up.content.cloneNode(true);
    cloneCard.querySelector("#short_pic_up_bgc").src = background;
    cloneCard.querySelector("#short_pic_cover_up_video_source").src = _video;
    let er = cloneCard.querySelector("#short_pic_cover_up_cover")
    er.src = "./transparent.jpg";
    er.style.opacity = "0";
    cloneCard.querySelector(".card_up_spen").innerText = card_up_spen;
    cloneCard.querySelector(".card_up_p_tital").innerText = tital;
    cloneCard.querySelector(".card_up_p").innerText = new_p;
    return cloneCard;
}
function getCard_up2(background, pic, card_up_spen, tital, new_p, new_number) {
    let cloneCard = cardTemplate_up.content.cloneNode(true);
    cloneCard.querySelector("#short_pic_up_bgc").src = background;
    cloneCard.querySelector(".short_pic_cover_up_cvr").src = pic;

    cloneCard.querySelector(".card_up_spen").innerText = card_up_spen;
    cloneCard.querySelector(".card_up_p_tital").innerText = tital;
    cloneCard.querySelector(".card_up_p").innerText = new_p;
    return cloneCard;
}
