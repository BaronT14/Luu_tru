const tabs = document.querySelectorAll(".tab-item");
const contents = document.querySelectorAll(".content-item");

var line = document.querySelector(".line");
var tabActice = document.querySelector(".tab-item.active");
line.style.left = tabActice.offsetLeft + 'px';
line.style.width = tabActice.offsetWidth + 'px';

tabs.forEach((tab, index)=>{
    tab.onclick = function(){
        document.querySelector(".tab-item.active").classList.remove('active');
        document.querySelector(".content-item.active").classList.remove('active');

        tab.classList.add('active')
        contents[index].classList.add('active');

        var tabActice = document.querySelector(".tab-item.active");
        line.style.left = tabActice.offsetLeft + 'px';
        line.style.width = tabActice.offsetWidth + 'px';
    }
});