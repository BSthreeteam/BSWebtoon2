
let xl_user = document.querySelector(".xl_user");
let md_user = document.querySelector(".md_user");
let useraccount = document.querySelector("#useraccount");
let xl_screen = document.querySelector("#xl_screen");
let md_screen = document.querySelector("#md_screen");
let my_comic = document.querySelector("#my_comic")
let md_accountinfo = document.querySelector(".md_accountinfo");
let md_my_comic = document.querySelector(".md_my_comic")
let xl_accountinfo = document.querySelector(".xl_accountinfo");
let xl_my_comic = document.querySelector(".xl_my_comic");
let sub_nav = document.querySelector('.sub-nav')
let main_nav = document.querySelector('.main-nav')
let xl_customer_service = document.querySelector('.xl_customer_service')

 //changescreen();
window.onload = function () {
    HomeReady();
    getcloneContent();
    xl_user.style.display = "none";
    xl_accountinfo.addEventListener("click", () => {
        xl_user.innerText = "";
        main_nav.style.display = "none";
        sub_nav.style.display = "none";
        main_body.style.display = "none";
        xl_user.style.display = "block";
        xl_user.appendChild(getcloneContent());

    })

    xl_my_comic.addEventListener("click", () => {
        xl_user.innerText = "";
        main_nav.style.display = "none";
        sub_nav.style.display = "none";
        main_body.style.display = "none";
        xl_user.style.display = "block";
        xl_user.appendChild(getclonecomic())
    })
    xl_customer_service.addEventListener("click", () => {
        xl_user.innerText = "";
        main_nav.style.display = "none";
        sub_nav.style.display = "none";
        main_body.style.display = "none";
        xl_user.style.display = "block";
        let terms = document.querySelector("#terms").content.cloneNode(true);
        xl_user.appendChild(terms)
    })
}

function getcloneContent() {
    cloneContent = useraccount.content.cloneNode(true);
    return cloneContent;
}

function getclonecomic() {
    let clonecomic = my_comic.content.cloneNode(true);
    return clonecomic;
}

//let login = document.getElementById('login');
//let user = document.getElementById('user');
//let logout = document.getElementById('logout');
//login.addEventListener('click', () => {

//    user.classList.add('d-block')
//    login.classList.add('d-none')
//})
//logout.addEventListener('click', () => {
//    xl_user.style.display = "none";
//    main_nav.style.display = "block";
//    sub_nav.style.display = "block";
//    main_body.style.display = "block";
//    user.classList.remove('d-block')
//    login.classList.remove('d-none')
//})


//let sub_nav_ul = document.querySelector('.sub-nav-ul');

//let subNavTemplate = document.querySelector('#sub-nav');
//HomeArray.forEach((data, index) => {
//    sub_nav_ul.appendChild(getNavClone(data.part, index));
//})

let body_recommendTemplate = document.querySelector('#body-recommend');
let body_hotTemplate = document.querySelector('#body-hot');
let main_context = document.querySelector('.main-context')

let nav_recommend = document.querySelector('.nav_recommend');
nav_recommend.addEventListener('click', () => {
    HomeReady();
})

let nav_hot = document.querySelector('.nav_hot');
nav_hot.addEventListener('click', () => {
    nav_hot.classList.remove('text-white')
    nav_hot.classList.add('nav-selected')
    nav_hot.classList.add('text-black')
    nav_recommend.classList.remove('nav-selected')
    nav_recommend.classList.add('text-white')
    main_context.innerHTML = "";
    HotArray.forEach((data, index) => {
        data.cardArray.forEach(card => {
            main_context.appendChild(getHotClone(card.videoName, card.videoTitleURL, card.videoBgURL, card.videoURL));
        })
    })
})

//function getNavClone(text, index) {
//    let clone = subNavTemplate.content.cloneNode(true);
//    let clone_a = clone.querySelector('a');
//    clone_a.innerHTML = text;
//    clone_a.classList.add(`nav-home${index}`);
//    return clone;
//}

function HomeReady() {
    nav_recommend.classList.remove('text-white')
    nav_recommend.classList.add('nav-selected')
    nav_recommend.classList.add('text-black')
    nav_hot.classList.remove('nav-selected')
    nav_hot.classList.add('text-white')
    main_context.innerHTML = "";
    RecommendArray.forEach((data, index) => {
        data.cardArray.forEach(card => {
            main_context.appendChild(getRecommendcarClone(card.title, card.text, card.tag, card.mainPicURL, card.bgPicURL));
        })
    })
}

function getRecommendcarClone(titlePicURL, text, tag, mainPicURL, bgPicURL) {
    let cloneCard = body_recommendTemplate.content.cloneNode(true);
    let clone_titlePicURL = cloneCard.querySelector('.title-pic')
    let clone_text = cloneCard.querySelector('p')
    let clone_tag = cloneCard.querySelector('span')
    let clone_a = cloneCard.querySelector('.work_a')
    let clone_mainPicURL = cloneCard.querySelector('.recommend-pic')
    let clone_bgPicURL = cloneCard.querySelector('.recommend-pic-bg')
    clone_titlePicURL.src = "https://picsum.photos/300/100/?random=10";
    clone_text.innerHTML = text;
    clone_tag.innerHTML = tag;
    clone_mainPicURL.src = mainPicURL;
    clone_bgPicURL.src = bgPicURL;
    // console.log(cloneCard.querySelector('a'))
    clone_a.href = "WorksPage/WorksPage"

    clone_mainPicURL.style.transform = `translateX(${window.scrollY / 100}%)`
    //clone_mainPicURL.style.transform = `translateX(${window.scrollY / 100}%)`

    window.addEventListener('mousewheel', (e) => {
        if (e.wheelDelta > 0) {
            // alert("滑輪向上滾動");
            console.log(window.scrollY)
            clone_mainPicURL.style.transform = `translateX(${window.scrollY / 1100}%)`
            clone_bgPicURL.style.transform = `translateX(-${window.scrollY / 700}%)`
        }
        if (e.wheelDelta < 0) {
            // alert("滑輪向下滾動");
            console.log(window.scrollY)
            clone_mainPicURL.style.transform = `translateX(${window.scrollY / 1100}%)`
            clone_bgPicURL.style.transform = `translateX(-${window.scrollY / 700}%)`
        }

    })

    return cloneCard;
}

function getHotClone(alt, videoTitleURL, videoBgURL, videoURL) {
    let cloneCard = body_hotTemplate.content.cloneNode(true);
    let clone_video_title = cloneCard.querySelector('.video-title')
    let clone_video_bg = cloneCard.querySelector('.video-bg')
    let clone_video = cloneCard.querySelector('video')
    clone_video_title.src = videoTitleURL;
    clone_video_title.alt = alt;
    clone_video_bg.src = videoBgURL;
    clone_video.src = videoURL;
    return cloneCard;
}
