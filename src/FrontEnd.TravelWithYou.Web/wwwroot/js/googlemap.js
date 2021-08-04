var googleMap = {
    markers:[],
    mapControl: null,
    initMap: function () {                
        map = new google.maps.Map(document.getElementById('boxMap'), {
            center: new google.maps.LatLng(19.4326296, -99.1331785),  //Centro de la Republica
            zoom: 6
            //,mapTypeId: google.maps.MapTypeId.RODMAP
        });
        googleMap.mapControl = map;
    },
    setValue: function (latitude, longitude, title, description, path) {
        googleMap.markers.push({
            latitude: latitude,
            longitude: longitude,
            title: title,
            description: description,
            path: path
        });
    },
    loadMarkets: function () {
        // Create markers.
        for (let i = 0; i < googleMap.markers.length; i++) {
            var mapItem = googleMap.markers[i];
            googleMap.setMarket(mapItem);
        }
    },
    setMarket: function (mapItem) {
        if (googleMap.mapControl == null) {
            googleMap.initMap();
        }
        var imageIcon = "https://maps.google.com/mapfiles/kml/shapes/parking_lot_maps.png"
        //switch (iconType){
        //    case 1:  //Destino
        //        imageIcon = "/images/icon-2.png";
        //        break;
        //    case 2:  //Punto Interes
        //        break;
        //}       
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(mapItem.latitude, mapItem.longitude),
            map: googleMap.mapControl,
            animation: google.maps.Animation.DROP,
            icon: mapItem.imageIcon,
            title: mapItem.title
        });
        var contentHtml = '<div><h2>' + mapItem.title + '</h2><p>' + mapItem.description + '</p><a href="' + mapItem.path + '" class="btn btn-primary btn-sm rounded-pill m-2">Ver más</a></div>';

        var infoWindow = new google.maps.InfoWindow({
            content: contentHtml       
        });
        google.maps.event.addListener(marker, function (event) {
            console.log('entro');
            infoWindow.open(googleMap.mapControl, this);
            $('.gm-style-iw').parent().children(':nth-child(1)').children(':nth-child(4)').remove();
        });

    }

}