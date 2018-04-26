// ***********************************************************************
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
$('#pdf').click(function () {
    var doc = new jsPDF('p', 'mm', [900, 210]);
    doc.addHTML($('#print'), 0  , 15, function() {

        
        doc.save('journeyplanner.pdf');
    });
});

