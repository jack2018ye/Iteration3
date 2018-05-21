

$(document).ready(function () {
   
    

    
    var oTable = $('#data').dataTable({
        
        "bPaginate": false,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false
    });
    var oTable2 = $('#data2').dataTable({
        "bPaginate": false,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false
    });
    var oTable3 = $('#data3').dataTable({
        "bPaginate": false,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false });

    var oTable4 = $('#data4').dataTable({
        "bPaginate": false,
        "bLengthChange": false,
        "bFilter": false,
        "bInfo": false,
        "bAutoWidth": false
    });
    oTable.fnSort([[4, 'asc']]);
    
    oTable3.fnSort([[4, 'asc']]);
});
