//implement the DOM to accept our code
$(document).ready(function () {

    //create function to hold everything and set interval
    setInterval(function () {
        NextSlide('home');
    }, 5000);

    setInterval(function () {
        NextSlide('dragon');
    }, 3700);

    setInterval(function () {
        NextSlide('trivia');
    }, 3700);

    setInterval(function () {
        NextSlide('pokerplayer');
    }, 3700);

    setInterval(function () {
        NextSlide('guessthatnumber');
    }, 3700);

    

    var NextSlide = function(name) {
        var activeSlide = $('#' + name + ' .active');
        //alert(activeSlide.attr('src'));
        //get the next slide
        var nextSlide = activeSlide.next();
        //make sure its a carousel slide
        if (!nextSlide.hasClass('image')) {
            nextSlide = activeSlide.parent().find('.image').first();
        }
        activeSlide.removeClass('active').addClass('hide');
        //remove the active class, add  the hide class to the active slide
        //remove the hide class, add the active class to the active slide
        nextSlide.removeClass('hide').addClass('active');
    };
    

    //AJAX POST FOR CONTACT FORM
    $('#contactForm').on('submit', function (event) {
        //prevents the default behavior of the form
        //(doesnt allow it to be submitted)
        event.preventDefault();
        //see if the form is valid
        if ($(this).valid()) {
            //ajax post
            var urlToPostTo = $(this).attr('action');
            var dataToSend = $(this).serialize();
            //alert("hello");
            $.post(urlToPostTo, dataToSend, function(data) {
                //update the container element with new HTML returned in the "data"
                $('#container').html(data);
            });
        }
    });

    $('#content').on('click', '.ajax-get', function (data) {
        var urlRequest = $(this).data('url');
        $.get(urlRequest, function (data) {
            $('#content').html(data);
        });
    });
});
