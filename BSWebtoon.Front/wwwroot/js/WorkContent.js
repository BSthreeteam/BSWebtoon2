let comic_content = document.querySelector(".comic_content");
let btn_last = document.querySelector(".btn_last");
let comicpic = document.querySelector("#comicpic");
let btn_next = document.querySelector(".btn_next");
let btn_comment = document.querySelector(".btn_comment");
let cloneContent = comicpic.content.cloneNode(true);
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

    for (let index = 1; index <= 30; index++) {
        comic_content.appendChild(getClonepic(index))
    }

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
        comic_content.appendChild(cloneContent)
    })
    //下一頁按鈕
    btn_next.addEventListener("click", () => {
        comic_content.innerText = "";
        comic_content.appendChild(cloneContent)
    })
    //留言
    btn_comment.addEventListener("click", () => {
        let container_fluid = document.querySelector(".comic_area");
        let comic = document.querySelector(".comic");
        let body = document.querySelector("body");
        let comment_text = document.querySelector(".comment_text")
        body.classList.add("bg-dark")
        comic.innerText = "";
        container_fluid.innerText = "";
        comment_text.innerText = "";
        let cloneContent = comment.content.cloneNode(true);
        // let more_function = document.querySelector(".more_function")
        comment_text.append(cloneContent)
        // let back=document.querySelector(".btn text-decoration-none my-2")
        // //返回按鈕
        // back.addEventListener("click",()=>{
        //     history.go(-1);
        // })
    })


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

            // else {
            //     //捲到底
            //     window.clearInterval(scrollId);
            //     alert("捲到底囉");
            // }
        }
    });


    //--------------------------------------------------


    for (let i = 1; i <= 30; i++) {
        mulu_row.appendChild(getCloneMULU(i))
        mulu_md_row.appendChild(getCloneMULU(i))
    }
}




function getClonepic(index) {
    let cloneCard = comicpic.content.cloneNode(true);
    cloneCard.querySelector('img').src = `https://picsum.photos/300/200/?random=${index}`
    return cloneCard;
}

function getCloneMULU(index) {
    let cloneCard = muluTemplate.content.cloneNode(true);
    cloneCard.querySelector('img').src = `https://picsum.photos/300/200/?random=${index}`
    cloneCard.querySelector('.card-title').innerHTML = `第${index}話`
    return cloneCard;
}

