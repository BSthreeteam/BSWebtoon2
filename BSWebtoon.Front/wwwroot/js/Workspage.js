let main_picture, main_comics_episode, local_video, collect_a, tidy, tidy_r, comics_episode, ep, illustrate, messages;
let ep_template, left_row, title_template, comics_name_click, moble_title_template;
window.onload = function () {
    ep = document.querySelector('.ep');
    illustrate = document.querySelector('.illustrate');
    messages = document.querySelector('.messages');
    local_video = document.querySelector('.local_video');
    collect_a = document.querySelector('.red');
    comics_name_click = document.querySelector('.comics_name_click');
    left_row = document.querySelector('.left_row');

    epCloned();

    ////(手機)選單
    //話次
    // ep = document.querySelector('.ep');
    ep.addEventListener('click', () => {
        console.log('1')
        left_row.innerText = "";
        epCloned();
    })
    //作品資訊
    // illustrate = document.querySelector('.illustrate');
    illustrate.addEventListener('click', () => {
        console.log('2')
        left_row.innerText = "";
        left_row.appendChild(mobleCloned('骨灰級菜鳥玩家', 'BONIEE', 'BONIEE', 'BONIEE,Step on a LEGO', 'REDICE STUDIO'))
    })
    //留言
    // messages = document.querySelector('.messages');
    messages.addEventListener('click', () => {
        console.log('3')
        left_row.innerText = "";
        let cloneContent = comment.content.cloneNode(true);
        left_row.appendChild(cloneContent);
    })
    ////點擊影片，影片開始播放。
    // local_video = document.querySelector('.local_video');
    local_video.addEventListener('click', () => {
        local_video.play();
    })
    ////點擊愛心，顏色變紅色
    // collect_a = document.querySelector('.red');
    collect_a.addEventListener('click', () => {
        collect_a.classList.add('text-danger');
    })
    ////title_cloned
    title_template = document.querySelector('#title_template');
    // comics_name_click = document.querySelector('.comics_name_click');
    //抓資料庫...
    comics_name_click.appendChild(getTitle('骨灰級菜鳥玩家', 'BONIEE,Step on a LEGO', 'REDICE STUDIO', '動作冒險', '843.9K', '82.1K', '原著'))
    ////
    function getTitle(title, author, publisher, category, whatch, good) {
        let cloneTitle = title_template.content.cloneNode(true);
        cloneTitle.querySelector(".title").innerText = title;
        cloneTitle.querySelector(".author").innerText = author;
        cloneTitle.querySelector(".publisher").innerText = publisher;
        cloneTitle.querySelector(".category").innerText = category;
        cloneTitle.querySelector(".whatch").innerText = whatch;
        cloneTitle.querySelector(".good").innerText = good;
        return cloneTitle;
    }
    ////moble_title_cloned
    function moble_title() {

    }
    moble_title_template = document.querySelector('#motle_title');
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
    function epCloned() {
        ep_template = document.querySelector('#ep_card');
        // left_row = document.querySelector('.left_row');
        for (let i = 1; i <= 50; i++) {
            left_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/${i.toString().padStart(2, "0")}`));
        }
    }
    function getCard(title, imgurl, content) {
        let cloneCard = ep_template.content.cloneNode(true);
        cloneCard.querySelector("img").src = imgurl;
        cloneCard.querySelector("h5").innerText = title;
        cloneCard.querySelector("p").innerText = content;
        cloneCard.querySelector("img").addEventListener('click', () => {
            window.location.href ="../EpContent/EpContent";
        })
        return cloneCard;
    }
    ////次序顛倒
    tidy = document.querySelector('.tidy');
    tidy_r = document.querySelector('.tidy_r')
    tidy.addEventListener('click', () => {
        tidy.style.display = "none";
        tidy_r.style.display = "flex";

        left_row.innerText = "";
        for (let i = 50; i >= 1; i--) {
            // getCard("第?話","https://picsum.photos/300/200/?random=64");
            left_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
        }
    })
    tidy_r.addEventListener('click', () => {
        tidy.style.display = "flex";
        tidy_r.style.display = "none";
        left_row.innerText = "";
        for (let i = 1; i <= 50; i++) {
            // getCard("第?話","https://picsum.photos/300/200/?random=64");
            left_row.appendChild(getCard(`第${i}話`, `https://picsum.photos/300/200/?random=${i}`, `2022/06/1${i}`));
        }

    })
    main_picture = document.querySelector('.main_picture');
    comics_episode = document.querySelector('.comics_episode');
    // let main_comics_episode_top = $('.main_comics_episode').offset().top;
    // let formTop, yPos;


    // $(window).scroll(function () {
    //     if ($(this).scrollTop() > 0) {
    //         $('html, body').animate({ 
    //             scrollTop: $('.main_comics_episode').offset().top
    //         }, "fast")

    //     }
    //     else if($(this).scrollTop() < main_comics_episode_top){
    //         $('html, body').animate({ scrollTop: 0 }, "fast")

    //     }
    // }).scroll()
    window.addEventListener('mousewheel', (event) => {
        event = event || window.event;
        if (event.wheelDelta > 0 || event.detail < 0) {
            //向上滾
            $('html, body').animate({ scrollTop: 0 }, "fast")

        }
        else {
            //向下滾
            // comics_episode.overflow-y="scroll"
            $('html, body').animate({
                scrollTop: $('.comics_episode').offset().top
            }, "fast")


        }
    })
}