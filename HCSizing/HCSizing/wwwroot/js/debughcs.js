$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);

    $('body').off('click', '#btn-save-rawdata').on('click', '#btn-save-rawdata', SaveRawData);

    $('body').off('click', '#btn-adddebugdata').on('click', '#btn-adddebugdata', AddDebugDataBody);
    $('body').off('click', '#btn-save-debugdata').on('click', '#btn-save-debugdata', SaveDebugData);
    $('body').off('click', '#btn-deletedebugdata').on('click', '#btn-deletedebugdata', ComfirmDelete);

    $('body').off('click', '#btn-OP').on('click', '#btn-OP', AddActualLockedOperator);
    $('body').off('click', '#btn-save-headcount').on('click', '#btn-save-headcount', SaveHeadCount);

    var months = ['Sep', 'Oct', 'Nov', 'Dec', 'Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug']


    function SaveRawData() {
        _tranferWC = $("#txt-wc").val();
        monthId = $(this).attr('data-monthId');
        var model = new Object();
        model.Wc = _tranferWC;
        model.MonthID = monthId;
        model.WorkingDayPerMonth = $(`#WorkingDayPerMonth-${monthId}`).text();
        model.WorkingHourPerShift = $(`#WorkingHourPerShift-${monthId}`).text()
        model.ShiftPatten = $(`#ShiftPatten-${monthId}`).text();
        model.WorkEfficiency = $(`#WorkEfficiency-${monthId}`).text();
        model.ForecastedVolume = $(`#ForecastedVolume-${monthId}`).text();
        model.Coverage = $(`#Coverage-${monthId}`).text();
        model.UpdateBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger;
        $.ajax({
            type: 'post',
            url: '/hcs/debug/UpdateDebugRawData',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                debugger
                if (response.statusCode == 200) {
                    bootbox.alert("Update successfully!", function () {
                        document.getElementById(`WorkingDayPerMonth-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`WorkingHourPerShift-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`ShiftPatten-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`WorkEfficiency-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`ForecastedVolume-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`Coverage-${monthId}`).setAttribute("style", "background-color: transparent");
                        LoadDebugResult(_tranferWC)
                    })
                }
                else if (response.statusCode == 400) {
                    bootbox.alert("400")
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }

    function SaveDebugData() {
        _tranferWC = $("#txt-wc").val();
        debugId = $(this).attr('data-debugId');
        var model = new Object();
        model.Id = debugId;
        model.DebugHitrateYield = $(`#DebugHitrateYield-${debugId}`).text();
        model.Station = $(`#Station-${debugId}`).text();
        model.HardcoreRate = $(`#HardcoreRate-${debugId}`).text()
        model.DebugTimeForNormalBoard = $(`#DebugTimeForNormalBoard-${debugId}`).text();
        model.DebugTimeForHardcoreBoard = $(`#DebugTimeForHardcoreBoard-${debugId}`).text();
        model.FinalYield = $(`#FinalYield-${debugId}`).text();
        model.DebugRetestPassYield = $(`#DebugRetestPassYield-${debugId}`).text();
        model.RMA = $(`#RMA-${debugId}`).text();
        model.UpdateBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger;
        $.ajax({
            type: 'post',
            url: '/hcs/debug/UpdateDebug',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                debugger
                if (response.statusCode == 200) {
                    bootbox.alert("Update successfully!", function () {
                        document.getElementById(`Station-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`DebugHitrateYield-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`HardcoreRate-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`DebugTimeForNormalBoard-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`DebugTimeForHardcoreBoard-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`FinalYield-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`DebugRetestPassYield-${debugId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`RMA-${debugId}`).setAttribute("style", "background-color: transparent");
                        LoadDebugResult(_tranferWC)
                    })
                }
                else if (response.statusCode == 400) {
                    bootbox.alert("400")
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }

    function Load() {
        $('#table-rawdata').html('');
        $('#table-debugdata').html('');
        $('#table-debugresult').html('');

        _tranferWC = $("#txt-wc").val();
        debugger
        if (_tranferWC == "0") {
            bootbox.alert('Please select WC')
        }
        else {
            LoadDebugRawData(_tranferWC)
            LoadDebugData(_tranferWC)
            LoadDebugResult(_tranferWC)
        }
    }

    function LoadDebugRawData(_tranferWC) {
        debugger
        $.ajax({
            type: 'post',
            url: '/hcs/debug/GetDebugRawDataByWC_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                $('#table-rawdata').html(response);
            }
        })
    }
         

    $('#frm-save-debugdata-body').validate({
        rules: {
            addDebugStation:
            {
                required: true,
            },
            addDebugHitrateYield:
            {
                required: true,
                range: [0, 100]
            },
            addNormalRate:
            {
                required: true,
                range: [0, 100]
            },
            addDebugTimeForNormalBoard:
            {
                required: true,
            },
            addDebugTimeForHardcoreBoard:
            {
                required: true,
            },
            addDebugFinalYield:
            {
                required: true,
                range: [0, 100]
            },

        },
        messages: {
            addDebugStation:
            {
                required: "You need fill in DebugStation",
            },
            addDebugHitrateYield:
            {
                required: "You need fill in DebugHitrateYield",
                range: 'DebugHitrateYield between {0} and {1}'
            },
            addNormalRate:
            {
                required: "You need fill in NormalRate",
                range: 'NormalRate between {0} and {1}'
            },
            addDebugTimeForNormalBoard:
            {
                required: "You need fill in DebugTimeForNormalBoard",
            },
            addDebugTimeForHardcoreBoard:
            {
                required: "You need fill in DebugTimeForHardcoreBoard",
            },
            addDebugFinalYield:
            {
                required: "You need fill in DebugFinalYield",
                range: 'DebugFinalYield between {0} and {1}'
            },

        }
    });
    function AddDebugDataBody() {
        debugger
        if ($('#frm-save-debugdata-body').valid()) {

            var model = new Object();
            _transferWC = $("#txt-wc").val();
            debugger
            model.Wc = _transferWC;
            model.Station = $('#txt-add-debug-Station').val();
            model.DebugHitrateYield = $('#txt-add-debug-DebugHitrateYield').val();
            model.HardcoreRate = $('#txt-add-debug-HardcoreRate').val()
            model.DebugTimeForNormalBoard = $('#txt-add-debug-DebugTimeForNormalBoard').val();
            model.DebugTimeForHardcoreBoard = $('#txt-add-debug-DebugTimeForHardcoreBoard').val();
            model.FinalYield = $('#txt-add-debug-FinalYield').val();
            model.UpdateBy = document.getElementById('userinfo').getAttribute('data-user');
            model.DebugRetestPassYield = $('#txt-add-debug-DebugRetestPassYield').val();
            model.RMA = $('#txt-add-debug-RMA').val();
            $.ajax({
                type: 'post',
                url: '/hcs/debug/AddDebugDataBody',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    debugger
                    if (response.statusCode == 200) {
                        bootbox.alert("Add station data successfully!", function () {
                            LoadDebugData(_transferWC)
                            LoadDebugResult(_tranferWC);
                        })
                    }
                    else if (response.statusCode == 400) {
                        bootbox.alert("400")
                    }
                    else {
                        bootbox.alert("Add Error! Please check input data")
                    }
                }
            })
        }

    }
    function LoadDebugData(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/debug/GetDebugDataByWC_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                $('#table-debugdata').html(response);
            }
        })
    }

    
    function ComfirmDelete() {

        var tranferId = $(this).data('debugdataid');
        var tranferStation = $(this).attr('data-station');
        var _tranferWC = $("#txt-wc").val();

        bootbox.confirm(`Are you sure to delete ${tranferStation}?`, function (result) {
            if (result) {
                Delete(tranferId, tranferStation, _tranferWC)
            }
        });
    }
    function Delete(tranferId, tranferStation, _tranferWC) {
        var model = new Object();
        debugger
        model.Id = tranferId;
        $.ajax({
            type: 'post',
            url: '/hcs/debug/DeleteDebugDataByIdAsync',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {

                var data = response.statusCode;
                if (data == 200) {
                    bootbox.alert(`Delete station ${tranferStation} successfully`, function () {
                        LoadDebugData(_tranferWC);
                        LoadDebugResult(_tranferWC);
                        //Load();
                    })
                }
                else {
                    bootbox.alert("Error");
                }
            }
        })
    }
    function LoadDebugResult(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/debug/GetDebugResult_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                debugger
                $('#table-debugresult').html(response);

                $.each(months, function (index, value) {
                    var lockedTech = `#lockedTech-${value}`;
                    var calculatedTech = `#calculatedTech-${value}`;
                    if (parseInt($(`${calculatedTech}`).text()) < parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: #FFFFB1");
                    }
                    else if (parseInt($(`${calculatedTech}`).text()) > parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: red");
                    }
                    else if (parseInt($(`${calculatedTech}`).text()) === parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: #00C851");
                    }

                    var lockedOP = `#Current-OP-${value}`;
                    var actualOP = `#ActualOP-${value}`;
                    if (parseInt($(`${actualOP}`).text()) < parseInt($(`${lockedOP}`).text())) {
                        $(`${lockedOP}`).attr("style", "background-color: #FFFFB1");
                    }
                    else if (parseInt($(`${actualOP}`).text()) > parseInt($(`${lockedOP}`).text())) {
                        $(`${lockedOP}`).attr("style", "background-color: red");
                    }
                    else if (parseInt($(`${actualOP}`).text()) === parseInt($(`${lockedOP}`).text())) {
                        $(`${lockedOP}`).attr("style", "background-color: #00C851");
                    }

                    var OP = `#OP-${value}`;
                    $(`${OP}`).val($(`${lockedOP}`).text());
                })

                var link = $("<a>");
                link.attr("onclick", "tablesToExcel(['tbl-debugresult', 'tbl-debugrawdata'], ['debugresult', 'debugrawdata'], 'export.xls', 'Excel')");
                link.attr("class", "btn btn-success");
                link.text("Export");
                link.addClass("link");

                $(".box").html(link);
            }
        })
    }


    function SaveHeadCount() {
        _transferWC = $("#txt-wc").val();
        _updatedBy = document.getElementById('userinfo').getAttribute('data-user');

        var model = new Object();
        model.Wc = _transferWC;
        model.Sep = $('#lockedTech-Sep').text();
        model.Oct = $('#lockedTech-Oct').text();
        model.Nov = $('#lockedTech-Nov').text();
        model.Dec = $('#lockedTech-Dec').text();
        model.Jan = $('#lockedTech-Jan').text();
        model.Feb = $('#lockedTech-Feb').text();
        model.Mar = $('#lockedTech-Mar').text();
        model.Apr = $('#lockedTech-Apr').text();
        model.May = $('#lockedTech-May').text();
        model.Jun = $('#lockedTech-Jun').text();
        model.Jul = $('#lockedTech-Jul').text();
        model.Aug = $('#lockedTech-Aug').text();
        model.UpdatedBy = _updatedBy;
        $.ajax({
            type: 'post',
            url: '/hcs/debug/UpdateDebugTech',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update current Tech successfully!", function () {
                        LoadDebugResult(_tranferWC)
                    })
                }
                else if (response.statusCode == 400) {
                    bootbox.alert("404")
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }

    function AddActualLockedOperator() {
        var model = new Object();
        _transferWC = $("#txt-wc").val();
        model.Wc = _transferWC;
        model.Sep = $('#OP-Sep').val();
        model.Oct = $('#OP-Oct').val();
        model.Nov = $('#OP-Nov').val();
        model.Dec = $('#OP-Dec').val();
        model.Jan = $('#OP-Jan').val();
        model.Feb = $('#OP-Feb').val();
        model.Mar = $('#OP-Mar').val();
        model.Apr = $('#OP-Apr').val();
        model.May = $('#OP-May').val();
        model.Jun = $('#OP-Jun').val();
        model.Jul = $('#OP-Jul').val();
        model.Aug = $('#OP-Aug').val();

        $.ajax({
            type: 'post',
            url: '/hcs/debug/AddActualLockedOperatorAsync',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update current OP successfully!", function () {
                        LoadDebugResult(_tranferWC)
                    })
                }
                else if (response.statusCode == 400) {
                    bootbox.alert("400")
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }
})