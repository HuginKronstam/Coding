var map;
var infoBox;
var dataLayer;

function GetMap() {

    //Set up the map
    map = new google.maps.Map(document.getElementById('mapDiv'), {
        zoom: 3,
        center: { lat: -28.024, lng: 140.887 }
    });

    infowindow = new google.maps.InfoWindow({
        content: ""
    });

     GetPhotos(webApiUrl);

}

function OnError(response) {
    alert("Could not obtain the picture coordinates");
}

function GetPhotos(serviceUrl) {
    //Call the WebAPI
    $.support.cors = true;
    $.ajax({
        url: serviceUrl,
        type: 'GET',
        dataType: 'json',
        success: DisplayPics,
        error: OnError
    });
}

function DisplayPics(response) {
    var location;
    var pin;
    $.each(response, function (index, photo) {
        location = { lng: Number(photo.Latitude), lat: Number(photo.Longitude) };

        var marker = new google.maps.Marker({
            position: location,
            map: map,
            title: photo.Title,
            ID: photo.PhotoID
        });

        marker.addListener('click', DisplayInfoBox);
    });

}

function DisplayInfoBox() {

        //Formulate the HTML for the infobox
        var htmlPinContent = "<div class='push-pin'>" + 
            "<a href='" + displayUrl + this.ID + "'>" +
            "<p>" + this.title + "</p>" +
            "<img height='80' width='80' src='" + pictureUrl + this.ID + "' />" +
            "</a>" +
            "</div>";

        //Set the location of the infobox and display it with the HTML

        infowindow.setContent(htmlPinContent);
        infowindow.open(map, this);
 
}
