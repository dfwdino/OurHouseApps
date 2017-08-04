
var la = document.getElementById("Latitude");
var lo = document.getElementById("Longitude");


$(document).ready(function () {
    getLocation();
});

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    }

}
function showPosition(position) {
    document.getElementById("Lat").value = position.coords.latitude;
    document.getElementById("Long").value = position.coords.longitude;
}