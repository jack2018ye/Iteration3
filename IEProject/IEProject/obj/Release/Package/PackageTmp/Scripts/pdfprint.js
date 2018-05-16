﻿// ***********************************************************************
// Assembly         : IEProject
// Author           : Kenneth
// Created          : 03-27-2018
//
// Last Modified By : Kenneth
// Last Modified On : 03-27-2018
// ***********************************************************************
// <copyright file="pdfprint.js" >

// <summary>This is a javascript file that handles the conversion of the table in the wheelchair public toilets page to a pdf file, for download.</summary>
// ***********************************************************************
//document.getElementById("pdf").onclick = function fun() {
//    var doc = new jsPDF('p', 'pt');
//    var elem = document.getElementById("data");
//    var res = doc.autoTableHtmlToJson(elem);
//    doc.autoTable(res.columns, res.data);
//    doc.save("toilets.pdf");
//}


//$('#pdf').click(function () {
//    html2canvas($("#print"), {
//        onrendered: function (canvas) {
//            var imgData = canvas.toDataURL(
//                'image/png');
//            var doc = new jsPDF('p', 'mm', [900, 300]);;
//            doc.addImage(imgData, 'PNG', 20, 20);
//            doc.save('team.pdf');
//        }

//    });
//});
//$('#pdf').click(function () {
//    var doc = new jsPDF();
//    doc.setFillColor(255, 255, 255, 255);

//    doc.addHTML($('#'), 0  , 15, function() {

        
//        doc.save('journeyplanner.pdf');
//    });
//});


$('#pdf').click(function () {
    var doc = new jsPDF('l', 'mm', [297, 210]);
   
    var elem = document.getElementById("data");
    var res = doc.autoTableHtmlToJson(elem);
    var elem2 = document.getElementById("data2");
    var res2 = doc.autoTableHtmlToJson(elem2);
    var elem3 = document.getElementById("data3");
    var res3 = doc.autoTableHtmlToJson(elem3);
    var elem4 = document.getElementById("data4");
    var res4 = doc.autoTableHtmlToJson(elem4);
   

    doc.autoTable(res.columns, res.data, {
        startY: 20,
        margin: { horizontal: 7 },
        styles: { overflow: 'hidden', columnWidth: 'wrap' },
        columnStyles: { text: { columnWidth: 'auto' } }
    });
    doc.autoTable(res2.columns, res2.data, {
        startY: doc.autoTable.previous.finalY + 15,
        margin: { horizontal: 7 },
        styles: { overflow: 'hidden', columnWidth: 'wrap' },
        columnStyles: { text: { columnWidth: 'auto' } }
    });
    doc.autoTable(res3.columns, res3.data, {
        startY: doc.autoTable.previous.finalY + 15,
        margin: { horizontal: 7 },
        styles: { overflow: 'hidden', columnWidth: 'wrap' },
        columnStyles: { text: { columnWidth: 'auto' } }
    });
   
    doc.save("Services.pdf");
});

