const ep = document.querySelector('.ep');
const illustrate = document.querySelector('.illustrate');
const messages = document.querySelector('.messages');
const local_video = document.querySelector('.local_video');
 const collect_a = document.querySelector('.red');
const comics_name_click = document.querySelector('.comics_name_click');
const ep_row = document.querySelector('.ep_row');
const copy = document.querySelector('.copy');
const free_watch = document.querySelector('.free_watch');
const local_video_bg = document.querySelector('.local_video_bg');
const play = document.querySelector('.play');
const message_box = document.querySelector('.message_box');
const main_picture = document.querySelector('.main_picture');
const comics_episode = document.querySelector('.comics_episode');
const mobile_title_box = document.querySelector('.mobile_title_box');
const ep_card = document.querySelector('.ep_card');
const comment_text = document.querySelector('.comment_text');
const card_box = document.querySelector('.card_box');


function reizeWindow(){
    let screen = window.screen.width;
    console.log(screen)
    window.addEventListener('resize', () => {
        if (screen <= 768) {
        //    message_box.classList.add('d-none');
        }
        else if (screen > 768) {
            //message_box.classList.remove('d-none');
            ep_row.innerText = "";
            ep_row.appendChild(card_box);
            console.log('///')
        }
    })
}

window.addEventListener('resize', () => {
    reizeWindow()
});

window.onload = function () {
    reizeWindow()
    //////點擊愛心，顏色變紅色
    //let check = document.querySelector('#heart');
    //collect_a.addEventListener('click', () => {
    //    if (!check.checked) {
    //        console.log('111')
    //        collect_a.classList.add('text-danger');
    //    }
    //    else {
    //        console.log('222')
    //        collect_a.classList.remove('text-danger');
    //    }
    //})


    ////分享-複製連結(ok)
    copy.addEventListener('click', () => {
        var dummy = document.createElement('input');
        console.log(dummy)
        document.body.appendChild(dummy);
        dummy.value = this.location.href;
        dummy.select();
        document.execCommand('copy');
        document.body.removeChild(dummy);
        alert('^^ 網址已複製 ^^');
    })
    ////(手機)選單
    //話次
    ep.addEventListener('click', () => {
        console.log('1')
        ep_row.innerText = "";
        ep_row.appendChild(card_box);
    })
    //作品資訊
    illustrate.addEventListener('click', () => {
        console.log('2')
        ep_row.innerText = "";
        mobile_title_box.classList.remove('d-none');
        mobile_title_box.classList.add('d-block');
        ep_row.appendChild(mobile_title_box);
    })
    //留言
    messages.addEventListener('click', () => {
        console.log('3')
        ep_row.innerText = "";
        comment_text.classList.remove('d-none');
        comment_text.classList.add('d-block');
        ep_row.appendChild(comment_text);
    })

    //點擊影片，影片開始播放。
    local_video.addEventListener('click', () => {
        local_video.play();
    })
    ////按下play鍵，開始撥放影片(ok)
    play.addEventListener('click', () => {
        local_video_bg.classList.remove('d-none');
        local_video_bg.play();
    })
    local_video_bg.addEventListener('ended', () => {
        local_video_bg.classList.add('d-none');
    })




    ////次序顛倒
    //tidy = document.querySelector('.tidy');
    //tidy_r = document.querySelector('.tidy_r')
    //tidy.addEventListener('click', () => {
    //    tidy.style.display = "none";
    //    tidy_r.style.display = "flex";

    //    ep_row.innerText = "";
    //    for (let i = 50; i >= 1; i--) {
    //        ep_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
    //    }
    //})
    //tidy_r.addEventListener('click', () => {
    //    tidy.style.display = "flex";
    //    tidy_r.style.display = "none";
    //    ep_row.innerText = "";
    //    for (let i = 1; i <= 50; i++) {
    //        ep_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
    //    }

    //})

    // //我們是用以下的方式讓它做出滾動的效果
    // window.addEventListener('mousewheel', (event) => {
    //     event = event || window.event;
    //     if (event.wheelDelta > 0 || event.detail < 0) {
    //         //向上滾
    //         $('html, body').animate({ scrollTop: 0 }, "fast")
    //     }
    //     else {
    //         //向下滾
    //         $('html, body').animate({
    //             scrollTop: $('.comics_episode').offset().top
    //         }, "fast")
    //     }
    // })
}
