﻿let comic_content = document.querySelector(".comic_content");
let btn_last = document.querySelector(".btn_last");
let comicpic = document.querySelector("#comicpic");
let btn_next = document.querySelector(".btn_next");


//let cloneContent = comicpic.content.cloneNode(true);
let mulu_row = document.querySelector('.mulu-row')
let muluTemplate = document.querySelector('#mulutemplate')
let mulu_btn = document.querySelector('#muluBTN')
let mulu_md_btn = document.querySelector('#mulu-mdBTN')
let mulu_md_row = document.querySelector('.mulu-md-row')

let scrollId, comic_content_Height;


let more_function = document.querySelector('.more_function');


//自動撥放按鈕
let btn_play = document.querySelector('.btn_play')

window.onload = function () {
    //for (let index = 1; index <= 30; index++) {
    //    comic_content.appendChild(getClonepic(index))
    //}
    //目錄按鈕
    comic_content.addEventListener("click", () => {
        more_function.style.display = "block"
        clearInterval(scrollId);
    })

    window.addEventListener('mousewheel', () => {
        more_function.style.display = "none"
    })

    //上一頁按鈕
    btn_last.addEventListener("click", () => {
        comic_content.innerText = "";
        //    for (let i = 1; i <= 30; i++) {
        //        comic_content.appendChild(getClonepic(i))
        //    }
    })
    //下一頁按鈕
    btn_next.addEventListener("click", () => {
        comic_content.innerText = "";
        //    for (let i = 1; i <= 30; i++) {
        //        comic_content.appendChild(getClonepic(i))
        //    }
    })
    //留言
    //btn_comment.addEventListener("click", () => {
    //    epContent.classList.add("d-none")
    //    Comment_area.classList.remove("d-none")

    //})



    //--------------------------------------------------


    //自動播放
    btn_play.addEventListener("click", () => {
        comic_content_Height = window.getComputedStyle(comic_content).getPropertyValue("height");
        comic_content_Height = parseInt(comic_content_Height);
        //自動捲動
        scrollId = setInterval(scroll, 10);
        function scroll() {
            if (comic_content.scrollTop + comic_content_Height < comic_content.scrollHeight) {
                //向下捲動
                comic_content.scrollTop++;
                console.log(comic_content.scrollTop)
            }
        }
    });


    //--------------------------------------------------




}

