var destinations = {
    ip: '',
    getDestinations: function () {
        var orderBy = $('#orderby').val().split('-');
        var id = orderBy[0];
        var type = orderBy[1];
        $.ajax({
            method: 'GET',
            url: '/destinations/' + id + '/' + type,
            success: function (respuesta) {
                $('#destinations-rows').html();
                $('#destinations-rows').html(respuesta);
            },
            error: function () {
                console.log("No se ha podido obtener la información");
            }
        });
    },
    init: function () {
        dataLayer.push({
            event: "ev-load-destinations",
            ip: "",
            quantity: 1
        });
        $('#icon-list').click(function () {
            $('.destinations-list').show();
            $('.destinations-list-map').hide();
            $('#filter-orderby').show();
        });
        $('#icon-location').click(function () {
            $('.destinations-list').hide();
            $('.destinations-list-map').show();
            $('#filter-orderby').hide();
        });
        googleMap.initMap();
        googleMap.loadMarkets();
    }
};