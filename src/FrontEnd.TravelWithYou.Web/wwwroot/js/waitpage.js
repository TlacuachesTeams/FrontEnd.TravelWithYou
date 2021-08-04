var waitPage = {
    showLoader: function(){
        $('.wait-page').show();
    },
    hideLoader: function(){
        $('.wait-page').hide();
    }
}

$(window).on('load',function(){
    waitPage.hideLoader();
});

$(document).ajaxStart(function() {
    waitPage.showLoader();
});

$(document).ajaxStop(function() {
    waitPage.hideLoader();
});