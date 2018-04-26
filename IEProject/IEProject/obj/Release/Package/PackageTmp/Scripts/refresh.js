$(document).ready(function () {

    if (document.getElementById('cartick').checked) {

        document.getElementById('car').style.visibility = "visible";


    }
    if (document.getElementById('traintick').checked) {

        document.getElementById('train').style.visibility = "visible";


    }
    if (document.getElementById('toilettick').checked) {

        document.getElementById('let').style.visibility = "visible";


    }
$("#cartick").change(function () {

    if (document.getElementById('cartick').checked) {

        document.getElementById('car').style.visibility = "visible";


    }
    else {

        document.getElementById('car').style.visibility = "hidden";
    }
    $("#car").html(data4);
});

$("#traintick").change(function () {

    if (document.getElementById('traintick').checked) {

        document.getElementById('train').style.visibility = "visible";


    }
    else {

        document.getElementById('train').style.visibility = "hidden";
    }
    $("#train").html(data2);
});
$("#toilettick").change(function () {

    if (document.getElementById('toilettick').checked) {

        document.getElementById('let').style.visibility = "visible";


    }
    else {

        document.getElementById('let').style.visibility = "hidden";
    }
    $("#let").html(data);
});
});
