document.getElementById("nav-btn").addEventListener("click", function (e) {
    var login = document.getElementById("login");
    var signup = document.getElementById("signup");
    if (document.getElementById("login").contains(e.target)) {
        login.classList.add("nav-btn-select");
        signup.classList.remove("nav-btn-select");
    } else {
        login.classList.remove("nav-btn-select");
        signup.classList.add("nav-btn-select");
    }
})
document.getElementById("res-icon-menu").addEventListener("click", function () {
    document.getElementById("nav-menu").classList.toggle("nav-menu-open");
});

window.addEventListener('click', function (e) {
    if (!document.getElementById('nav-bar').contains(e.target)) {
        document.getElementById("nav-menu").classList.remove("nav-menu-open");
    }
});



//----------slider------------
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    if (slides.length > 0)
        slides[slideIndex - 1].style.display = "block";
}

//----------slider------------


jQuery(document).ready(function ($) {

    var slideCount = $('#slider ul li').length;
    var slideWidth = $('#slider ul li').width();
    var slideHeight = $('#slider ul li').height();



    $('#slider ul li:last-child').prependTo('#slider ul');

    function moveLeft() {
        $('#slider ul').animate({
            left: + slideWidth
        }, 200, function () {
            $('#slider ul li:last-child').prependTo('#slider ul');
            $('#slider ul').css('left', '');
        });
    };

    function moveRight() {

        $('#slider ul').animate({
            left: - slideWidth
        }, 200, function () {
            $('#slider ul li:first-child').appendTo('#slider ul');
            $('#slider ul').css('left', '');
        });
        setTimeout(moveRight, 2500);
    };

    setTimeout(moveRight, 2500);

    $('a.control_prev').click(function (e) {
        e.preventDefault();
        moveLeft();
    });

    $('a.control_next').click(function (e) {
        e.preventDefault();
        moveRight();
    });

    $("#slider ul li").on("swipeleft", function () {
        moveRight();
    });

    $("#slider ul li").on("swiperight", function () {
        moveLeft();
    });

});

document.getElementById("close-signup").addEventListener("click", function () {
    document.getElementById("signup-flow").style.display = "none";
});

document.getElementById("lang-drop").addEventListener("click", function () {
    document.getElementById("lang-bar-sub").classList.toggle("dis-block");
});
window.addEventListener('click', function (e) {
    if (!document.getElementById('lang-drop').contains(e.target)) {
        document.getElementById("lang-bar-sub").classList.remove("dis-block");
    }
});


var news_btn = document.getElementById("news-btn");
if (news_btn != null && news_btn != undefined) {
    news_btn.addEventListener("click", function () {
        var email = document.getElementById("news-input").value;
        $.post('/News-Register', { mail: email }, function (res) {
            if (res === 200) {
                document.getElementById("res-status").classList.add("green");
                document.querySelector("#res-status > i").classList.add("fa-check");
                document.getElementById("res-status").classList.remove("red");
                document.querySelector("#res-status > i").classList.remove("fa-times");
            } else {
                document.getElementById("res-status").classList.remove("green");
                document.querySelector("#res-status > i").classList.remove("fa-check");
                document.getElementById("res-status").classList.add("red");
                document.querySelector("#res-status > i").classList.add("fa-times");
            }
        })
    })
}

var news_btn_top = document.getElementById("news-btn-top");
if (news_btn_top != null && news_btn_top != undefined) {
    news_btn_top.addEventListener("click", function () {
        var email = document.getElementById("news-input-top").value;
        $.post('/News-Register', { mail: email }, function (res) {
            if (res === 200) {
                window.location = window.location;
            }
        })
    })
}