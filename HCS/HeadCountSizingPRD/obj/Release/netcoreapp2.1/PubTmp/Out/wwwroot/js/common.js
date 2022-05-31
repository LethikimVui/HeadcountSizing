$(document).ready(function () {
    function fncOnchangeDowntimeType() {
        var _downtimeType = $("#txt-dowtimetype").val();
        var _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        $('.hiddenTab').attr("style", "visibility: hidden");
        $('#add-DowntimeDetail').empty();
        $('#add-DowntimeDetail').append($('<option>', {
            value: "0",
            text: "--Please Select--"
        }));
        debugger
        //var model = new Object();

        //model.CustId = _tranferWCId;
        //model.DowntimeType = _downtimeType;
        //model.FiscalYearId = 1;
        $.ajax({
            type: 'post',
            url: '/TestTech/GetDowntimeDetailByDowntimeType',
            dataType: 'json',
            data: { downtimetype: _downtimeType},
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                var data = response.result;
                debugger
                $.each(data, function (index, value) {
                    $('#add-DowntimeDetail').append($('<option>', {
                        value: value.downtimeDetail,
                        text: value.downtimeDetail
                    }));
                });
            }
        });
    }
    
  
})