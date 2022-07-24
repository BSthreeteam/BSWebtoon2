let main_picture, main_comics_episode, local_video/*, collect_a*/, tidy, tidy_r, comics_episode, ep, illustrate, messages, copy, play;
let ep_template, ep_row, comics_name_click, moble_title_template, ticket_template, free_watch, local_video_bg, message_box;
window.onload = function () {
    ep = document.querySelector('.ep');
    illustrate = document.querySelector('.illustrate');
    messages = document.querySelector('.messages');
    local_video = document.querySelector('.local_video');
    //collect_a = document.querySelector('.red');
    comics_name_click = document.querySelector('.comics_name_click');
    ep_row = document.querySelector('.ep_row');
    //local_video = document.querySelector('.local_video');
    copy = document.querySelector('.copy');
    free_watch = document.querySelector('.free_watch');
    local_video_bg = document.querySelector('.local_video_bg');
    play = document.querySelector('.play');
    message_box = document.querySelector('.message_box');
    main_picture = document.querySelector('.main_picture');
    comics_episode = document.querySelector('.comics_episode');



    //epCloned();
    ////按下play鍵，開始撥放影片
    play.addEventListener('click', () => {
        local_video_bg.classList.remove('d-none');
        local_video_bg.play();
    })
    local_video_bg.addEventListener('ended', () => {
        local_video_bg.classList.add('d-none');
    })

    ////分享-複製連結
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

    //留言
    let comment = document.querySelector('#comment');
    function clonemessage() {
        let cloneContent = comment.content.cloneNode(true);
        return cloneContent;
    }
    messages.addEventListener('click', () => {
        console.log('3')
        ep_row.innerText = "";
        ep_row.appendChild(clonemessage());
    })
    ////桌機留言區
    message_box.appendChild(clonemessage());



    let screen = window.innerWidth;
    console.log(screen)
    window.addEventListener('resize', () => {
        if (screen <= 768) {
            message_box.remove("d-flex");
            console.log("small")
        }
        else if (screen > 768) {
            //ep_row.innerText = "";
            //epCloned();
            message_box.classList.add("d-flex");
            console.log('///')
        }
    })
    ////(手機)選單
    //話次
    ep.addEventListener('click', () => {
        console.log('1')
        ep_row.innerText = "";
        //epCloned();
    })
    //作品資訊
    illustrate.addEventListener('click', () => {
        console.log('2')
        ep_row.innerText = "";
        ep_row.appendChild(mobleCloned('骨灰級菜鳥玩家', 'BONIEE', 'BONIEE', 'BONIEE,Step on a LEGO', 'REDICE STUDIO'))
    })

    ////點擊影片，影片開始播放。
    //local_video.addEventListener('click', () => {
    //    local_video.play();
    //})

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

    function getView(imgUrl, imgUrlMov) {
        let cloneView = View_template.content.cloneNode(true);
        cloneView.querySelector(".webm").src = imgUrl;
        cloneView.querySelector(".mov").src = imgUrlMov;
        return cloneView;
    }
    ////moble_title_cloned
    moble_title_template = document.querySelector('#mobile_title');
    function mobleCloned(title, mo_word, mo_pic, mo_author, mo_publisher) {
        let cloneMoble = moble_title_template.content.cloneNode(true);
        cloneMoble.querySelector(".mo_ti").innerText = title;
        cloneMoble.querySelector(".mo_word").innerText = mo_word;
        cloneMoble.querySelector(".mo_pic").innerText = mo_pic;
        cloneMoble.querySelector(".mo_author").innerText = mo_author;
        cloneMoble.querySelector(".mo_publisher").innerText = mo_publisher;
        return cloneMoble;
    }
    ////話次cloned
    //function epCloned() {
    //    ep_template = document.querySelector('#ep_card');
    //    for (let i = 1; i <= 50; i++) {
    //        ep_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/${i.toString().padStart(2, "0")}`));
    //    }
    //}
    //function getCard(title, imgurl, content) {
    //    let cloneCard = ep_template.content.cloneNode(true);
    //    cloneCard.querySelector("img").src = imgurl;
    //    cloneCard.querySelector("h5").innerText = title;
    //    cloneCard.querySelector("p").innerText = content;
    //    return cloneCard;
    //}

    ////次序顛倒
    tidy = document.querySelector('.tidy');
    tidy_r = document.querySelector('.tidy_r')
    tidy.addEventListener('click', () => {
        tidy.style.display = "none";
        tidy_r.style.display = "flex";

        ep_row.innerText = "";
        for (let i = 50; i >= 1; i--) {
            ep_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
        }
    })
    tidy_r.addEventListener('click', () => {
        tidy.style.display = "flex";
        tidy_r.style.display = "none";
        ep_row.innerText = "";
        for (let i = 1; i <= 50; i++) {
            ep_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
        }

    })


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
