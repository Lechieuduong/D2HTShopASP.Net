var MenuItems = document.getElementById("MenuItems");
MenuItems.style.maxHeight = "0px";

function menutoggle() {
    if (MenuItems.style.maxHeight == "0px") {
        MenuItems.style.maxHeight = "200px";
    } else {
        MenuItems.style.maxHeight = "0px";
    }
}

function search() {
    var searchBox = document.querySelector('.search-box');
    if (searchBox.style.display == "none") {
        searchBox.style.display = "block";
    } else {
        searchBox.style.display = "none";
    }

}