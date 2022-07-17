function bgcolor() {
    if (document.getElementById("flexRadioDefault1").checked) {
        // body深色
        document.getElementById("body_bgc").style.backgroundColor = "#1c1c1c";
        document.getElementById("box").style.backgroundColor = "#1c1c1c";
        document.getElementById("box").style.color = "#fff";
        document.getElementById("top").style.color = "#fff";
    }

    if (document.getElementById("flexRadioDefault2").checked) {
        // body淺色
        document.getElementById("body_bgc").style.backgroundColor = "#fff";

        // box淺色
        document.getElementById("box").style.backgroundColor = "#fff";
        document.getElementById("box").style.color = "#000";
        document.getElementById("top").style.color = "#000";
    }
}