//load the DOM into jQuery
$(document).ready(function () {
    //functions go inside the document.ready() callback
    $('li').on('click', function () {
        //    $(this).css('color', 'red').css('color', 'gray');
        //});
        //tabs START
        $('.tabSelection li').on('click', function () {
            var tabID = $(this).data('tabid');
            var activeTab = $('.active');
            //select tab to activate
            var selectedTab = $('#' + tabID);
            //remove the active class from the active tab
            // and add the hide class to the active tab
            activeTab.removeClass('.active');
            activeTab.addClass('.hide');
            //remove the hide class from the selectedTab
            //and add the active class from the selectedTab
            selectedTab.removeClass('.hide').addClass('.active');
        });
        //tabs END    
    });
    //carousel functions start
        $('.carousel-next').on('click', function () {
            //get the active slide
            var activeSlide = $('.carousel.active');
            //get the next slide
            var nextSlide = activeSlide.next();
            //make sure its a carousel slide
            if (!nextSlide.hasClass('carousel')) {
                nextSlide = $('.carousel').first();
            }
            //remove the active class, add the hide class to the active slide
            activeSlide.removeClass('active').addClass('hide');
            //remove the hide class, add the active class to the active slide
            nextSlide.removeClass('hide').addClass('active');
        });
    //carousel functions end

    ////AJAX GET
    //    $('#content .ajax-get').on('click' function() {
    //        //ajax get, we specify jQuery($).get()
    //        $.get('/ajaxget/cats', function(data) {
    //            //replace the #content from html
    //           $('#content').html(data)  
    //        });

    //    });

    //MUCH BETTER AJAX CODE
    //use the second selector to apply this function to any matching elements that appear on the page AT ANY TIME
        $('#content').on('click', '.ajax-get', function (data) {
            var urlRequest = $(this).data('url');
            $.get(urlRequest, function (data) {
                $('#content').html(data);
            });

        });

    //AJAX POST FOR CONTACT FORM
        $('#contactform').on('submit', function (event) {
            //prevents the default behavior of the form
            //(doesnt allow it to be submitted)
            event.preventDefault();
            //see if the form is valid
            if ($(this.valid()) {
                //ajax post
                var urlToPostTo = $(this).attr('action');
                var dataToSend = $(this).serialize();
                alert(dataToSend);
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
