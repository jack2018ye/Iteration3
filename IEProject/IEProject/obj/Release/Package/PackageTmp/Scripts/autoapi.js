// ***********************************************************************
// Assembly         : IEProject
// Author           : Kenneth
// Created          : 03-24-2018
//
// Last Modified By : Kenneth
// Last Modified On : 03-28-2018
// ***********************************************************************
// <copyright file="autoapi.js">
// <summary>This is a javascript file that uses google's api to autosuggest addresses when input is being
//made on the destination address text field. It also Collects the laitude and longitude for the address 
//and stores it in the public toilet model.</summary>
// ***********************************************************************
document.getElementById('Latitude').value = 0;
document.getElementById('Longitude').value = 0;

var strictBounds = new google.maps.LatLngBounds(
  new google.maps.LatLng(-37.861371, 144.938679),
  new google.maps.LatLng(-37.796289, 144.998761));

google.maps.event.addDomListener(window, 'load', function () {
    var options = {
        bounds: strictBounds,
        types: ['geocode'],
        componentRestrictions: { country: "AU" },
       
    };
  


    var input = document.getElementById('Address');
    $(input).on('input', function () {
        var str = input.value;
        var prefix = 'Melbourne, ';
        if (str.indexOf(prefix) == 0) {
            console.log(input.value);
        } else {
            if (prefix.indexOf(str) >= 0) {
                input.value = prefix;
            } else {
                input.value = prefix + str;
            }
        }

    });

    var places = new google.maps.places.Autocomplete(input, options);

  

    geocoder = new google.maps.Geocoder();

    var address = document.getElementById('Address').value;


    var selectstatus = false;
    document.getElementById('select').value = selectstatus;

    google.maps.event.addListener(places, 'place_changed', function () {
        selectstatus = true;
        document.getElementById('select').value = selectstatus;
        var place = places.getPlace();
        var lat = place.geometry.location.lat();
        var lng = place.geometry.location.lng();

        
    });






});
var st = document.getElementById('Address').value;
