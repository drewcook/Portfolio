//implement the DOM to accept our code
$(document).ready(function () {
    ////carousel functions start
    //$('.div1 > .image img').on('click', function () {
    //    //get the active slide
    //    var activeSlide = $('.image.active');
    //    //get the next slide
    //    var nextSlide = activeSlide.next();
    //    //make sure its a carousel slide
    //    if (!nextSlide.hasClass('image')) {
    //        nextSlide = $('.image').first();
    //    }
    //    //remove the active class, add the hide class to the active slide
    //    activeSlide.removeClass('active').addClass('hide');
    //    //remove the hide class, add the active class to the active slide
    //    nextSlide.removeClass('hide').addClass('active');
    //});
    ////carousel functions end

    //create function to hold everything and set interval
    setInterval(function () {
        NextSlide('dragon');
    }, 3000);

    setInterval(function () {
        NextSlide('trivia');
    }, 3000);

    setInterval(function () {
        NextSlide('pokerplayer');
    }, 3000);

    setInterval(function () {
        NextSlide('guessthatnumber');
    }, 3000);

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
    
    //checking for validity when submitting on contact page
    $('#contactForm').on('submit', function (event) {
        event.preventDefault();
        if ($(this).valid())
            $.post($(this).attr('action'), $(this).serialize(), function (data) {
                $('#container').html(data);
            });

    });


    //carousel for the games on work page
    $('carousel-next').on('click', function () {
        (this);
    });
   




});