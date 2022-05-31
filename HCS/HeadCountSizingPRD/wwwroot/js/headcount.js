$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);  

    function Load() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        var model = new Object();
        model.CustId = _tranferWCId;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        //model.FiscalId = 0;
        $.ajax({
            type: 'post',
            url: '/home/Summary_part',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (data) {
                debugger
                $('#table').html(data);
            }
        })
    }
    
  
})