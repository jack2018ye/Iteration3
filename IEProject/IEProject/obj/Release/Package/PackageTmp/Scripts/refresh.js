$(document).ready(function () {

    if (document.getElementById('cartick').checked) {

        document.getElementById('car').style.display = "block";


    }
    if (document.getElementById('traintick').checked) {

        document.getElementById('train').style.display = "block";


    }
    if (document.getElementById('toilettick').checked) {

        document.getElementById('let').style.display = "block";


    }
    if(document.getElementById('accomodationselect').checked==true ||  document.getElementById('hairdressingselect').checked ==true||  document.getElementById('barselect').checked==true||  document.getElementById('cafeselect').checked==true||  document.getElementById('retailselect').checked==true||  document.getElementById('supermarketselect').checked==true) {

        document.getElementById('b1').style.display = "block";


    }
$("#cartick").change(function () {

    if (document.getElementById('cartick').checked) {

        document.getElementById('car').style.display = "block";


    }
    else {

        document.getElementById('car').style.display = "none";
    }
    $("#car").html(data4);
});

$("#traintick").change(function () {

    if (document.getElementById('traintick').checked) {

        document.getElementById('train').style.display = "block";


    }
    else {

        document.getElementById('train').style.display = "none";
    }
    $("#train").html(data2);
});
$("#toilettick").change(function () {

    if (document.getElementById('toilettick').checked) {

        document.getElementById('let').style.display = "block";


    }
    else {

        document.getElementById('let').style.display = "none";
    }
    $("#let").html(data);
});
$('#others input[type=checkbox]').change(function() {

    if (document.getElementById('accomodationselect').checked == true || document.getElementById('hairdressingselect').checked == true || document.getElementById('barselect').checked == true || document.getElementById('cafeselect').checked == true || document.getElementById('retailselect').checked == true || document.getElementById('supermarketselect').checked == true) {

        document.getElementById('b1').style.display = "block";


    }
    else {

        document.getElementById('b1').style.display = "none";
    }
    $("#b1").html(data3);
});
});
