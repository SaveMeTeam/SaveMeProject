if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(function (p) {
        var LatLng = new google.maps.LatLng(p.coords.latitude, p.coords.longitude);
        var mapOptions = {
            center: LatLng,
            zoom: 13,
            mapTypeId: google.maps.MapTypeId.ROADMAP

        };

        var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);
        var marker = new google.maps.Marker({
            position: LatLng,
            map: map,
            title: "<div style = 'height:60px;width:200px'><b>Your location:</b><br />Latitude: " + p.coords.latitude + "<br />Longitude: " + p.coords.longitude
        });
        google.maps.event.addListener(marker, "click", function (e) {
            var infoWindow = new google.maps.InfoWindow();
            infoWindow.setContent(marker.title);
            infoWindow.open(map, marker);
        });



    });
} else {
    alert('Geo Location feature is not supported in this browser.');
}
function SetTextBoxValue() {
    // document.getElementById('txtDes').value =
    navigator.geolocation.getCurrentPosition(function (point) {
        var LatLng = new google.maps.LatLng(point.coords.latitude, point.coords.longitude);
        var Lat = point.coords.latitude
        var Lng = point.coords.longitude
        document.getElementById('txtLat').value = Lat.toFixed(4)
        document.getElementById('txtLng').value = Lng.toFixed(4)
        document.getElementById("txtCon").innerHTML = "Location Recorded!"
    });
}
