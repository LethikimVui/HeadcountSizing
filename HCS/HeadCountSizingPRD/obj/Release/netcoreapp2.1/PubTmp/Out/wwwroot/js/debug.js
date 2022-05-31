$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-save-rawdata').on('click', '#btn-save-rawdata', SaveRawData);
    $('body').off('click', '#btn-adddebugdata').on('click', '#btn-adddebugdata', AddDebugDataBody);
    $('body').off('click', '#btn-save-debugdata').on('click', '#btn-save-debugdata', SaveDebugData);
    $('body').off('click', '#btn-deletedebugdata').on('click', '#btn-deletedebugdata', ComfirmDelete);
    $('body').off('click', '#btn-save-headcount').on('click', '#btn-save-headcount', SaveHeadCount);

    var months = ['Sep', 'Oct', 'Nov', 'Dec', 'Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug']

    function Load() {
        $('#table-rawdata').html('');
        $('#table-debugdata').html('');
        $('#table-debugresult').html('');
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        debugger
        if (!_tranferWCId) {
            bootbox.alert('Please select WC')
        }
        else {
            LoadDebugRawData();
            LoadDebugData();
            LoadDebugResult();
        }
    }

    function LoadDebugRawData() {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetRawDataAsync_partialview',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                $('#table-rawdata').html(response);
            }
        })
    }
    function SaveRawData() {
        var e = document.getElementById("txt-wc");
        _tranferWCId = parseInt(e.value);
        monthId = $(this).attr('data-monthId');
        shiftId = $(`#ShiftPatten-${monthId}`).attr('data-shiftId');

        var model = new Object();
        model.CustId = _tranferWCId;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        model.MonthId = monthId;
        model.ShiftId = shiftId;
        model.WorkingEfficiency = $(`#WorkingEfficiency-${monthId}`).text();
        model.ForecastedVolume = $(`#ForecastedVolume-${monthId}`).text();
        model.WorkingDayPerMonth = $(`#WorkingDayPerMonth-${monthId}`).text();
        model.WorkingHourPerShift = $(`#WorkingHourPerShift-${monthId}`).text()
        model.Coverage = $(`#Coverage-${monthId}`).text();
        model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger;
        $.ajax({
            type: 'post',
            url: '/debug/UpdateRawData',
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
                        document.getElementById(`WorkingEfficiency-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`ForecastedVolume-${monthId}`).setAttribute("style", "background-color: transparent");
                        document.getElementById(`Coverage-${monthId}`).setAttribute("style", "background-color: transparent");
                        LoadDebugResult()
                    })
                }
                else if (response.statusCode == 400) {
                    bootbox.alert("Update 400")
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }

    function LoadDebugData() {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetDebugData_partialview',
            data: JSON.stringify(model),
            contentType: "application/json;charset=utf-8",
            success: function (response) {
                $('#table-debugdata').html(response);
            }
        })
    }
    function SaveDebugData() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        debugId = $(this).attr('data-debugid');
        var model = new Object();
        model.Id = debugId;
        model.Station = $(`#Station-${debugId}`).text();
        model.HitrateYield = $(`#DebugHitrateYield-${debugId}`).text();
        model.HardcoreRate = $(`#HardcoreRate-${debugId}`).text()
        model.TimeForNormalBoard = $(`#DebugTimeForNormalBoard-${debugId}`).text();
        model.TimeForHardcoreBoard = $(`#DebugTimeForHardcoreBoard-${debugId}`).text();
        model.FinalYield = $(`#FinalYield-${debugId}`).text();
        model.RetestPassYield = $(`#DebugRetestPassYield-${debugId}`).text();
        model.RMA = $(`#RMA-${debugId}`).text();
        model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger;
        $.ajax({
            type: 'post',
            url: '/debug/UpdateDebugData',
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
                        LoadDebugResult()
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
            _tranferWCId = parseInt(document.getElementById("txt-wc").value);
            fiscalYearId = parseInt(document.getElementById("txt-fy").value);
            debugger
            model.CustId = _tranferWCId;
            model.Station = $('#txt-add-debug-Station').val();
            model.HardcoreRate = $('#txt-add-debug-HardcoreRate').val()
            model.TimeForHardcoreBoard = $('#txt-add-debug-DebugTimeForHardcoreBoard').val();
            model.TimeForNormalBoard = $('#txt-add-debug-DebugTimeForNormalBoard').val();
            model.FinalYield = $('#txt-add-debug-FinalYield').val();
            model.HitrateYield = $('#txt-add-debug-DebugHitrateYield').val();
            model.RetestPassYield = $('#txt-add-debug-DebugRetestPassYield').val();
            model.RMA = $('#txt-add-debug-RMA').val();
            model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
            model.FiscalYearId = fiscalYearId;

            $.ajax({
                type: 'post',
                url: '/debug/AddDebugDataBody',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    debugger
                    if (response.statusCode == 200) {
                        bootbox.alert("Add station data successfully!", function () {
                            LoadDebugData(_tranferWCId)
                            LoadDebugResult(_tranferWCId);
                        })
                    }
                    else if (response.statusCode == 400) {
                        bootbox.alert("400")
                    }
                    else {
                        bootbox.alert("Add Error!")
                    }
                }
            })
        }

    }


    function ComfirmDelete() {
        var tranferId = $(this).data('debugdataid');
        var tranferStation = $(this).attr('data-station');
        var _tranferWCId = parseInt(document.getElementById("txt-wc").value);

        bootbox.confirm(`Are you sure to delete ${tranferStation}?`, function (result) {
            if (result) {
                Delete(tranferId, tranferStation, _tranferWCId)
            }
        });
    }
    function Delete(tranferId, tranferStation, _tranferWCId) {
        var model = new Object();
        debugger
        model.Id = tranferId;
        $.ajax({
            type: 'post',
            url: '/debug/DeleteDebugData',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {

                var data = response.statusCode;
                if (data == 200) {
                    bootbox.alert(`Delete station ${tranferStation} successfully`, function () {
                        LoadDebugData(_tranferWCId);
                        LoadDebugResult(_tranferWCId);
                    })
                }
                else {
                    bootbox.alert("Error");
                }
            }
        })
    }


    function LoadDebugResult() {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetDebugResult_partialview',
            data: JSON.stringify(model),
            contentType: "application/json;charset=utf-8",
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
                link.attr("onclick", "tablesToExcel(['tbl-debugresult', 'tbl-debugrawdata', 'tbl-debugdata'], ['debugresult', 'debugrawdata', 'debugdata'], 'Debug.xls', 'Excel')");

                link.attr("class", "btn btn-success");
                link.text("Export");
                link.addClass("link");

                $(".box").html(link);
            }
        })
    }
    function SaveHeadCount() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        _updatedBy = document.getElementById('userinfo').getAttribute('data-user');

        var model = new Object();
        model.CustId = _tranferWCId;
        model.Sep = $('#lockedTech-Sep').text() ? parseInt($('#lockedTech-Sep').text()) : 0;
        model.Oct = $('#lockedTech-Oct').text() ? parseInt($('#lockedTech-Oct').text()) : 0;
        model.Nov = $('#lockedTech-Nov').text() ? parseInt($('#lockedTech-Nov').text()) : 0;
        model.Dec = $('#lockedTech-Dec').text() ? parseInt($('#lockedTech-Dec').text()) : 0;
        model.Jan = $('#lockedTech-Jan').text() ? parseInt($('#lockedTech-Jan').text()) : 0;
        model.Feb = $('#lockedTech-Feb').text() ? parseInt($('#lockedTech-Feb').text()) : 0;
        model.Mar = $('#lockedTech-Mar').text() ? parseInt($('#lockedTech-Mar').text()) : 0;
        model.Apr = $('#lockedTech-Apr').text() ? parseInt($('#lockedTech-Apr').text()) : 0;
        model.May = $('#lockedTech-May').text() ? parseInt($('#lockedTech-May').text()) : 0;
        model.Jun = $('#lockedTech-Jun').text() ? parseInt($('#lockedTech-Jun').text()) : 0;
        model.Jul = $('#lockedTech-Jul').text() ? parseInt($('#lockedTech-Jul').text()) : 0;
        model.Aug = $('#lockedTech-Aug').text() ? parseInt($('#lockedTech-Aug').text()) : 0;
        model.Sep_op = $('#Current-OP-Sep').text() ? parseInt($('#Current-OP-Sep').text()) : 0;
        model.Oct_op = $('#Current-OP-Oct').text() ? parseInt($('#Current-OP-Oct').text()) : 0;
        model.Nov_op = $('#Current-OP-Nov').text() ? parseInt($('#Current-OP-Nov').text()) : 0;
        model.Dec_op = $('#Current-OP-Dec').text() ? parseInt($('#Current-OP-Dec').text()) : 0;
        model.Jan_op = $('#Current-OP-Jan').text() ? parseInt($('#Current-OP-Jan').text()) : 0;
        model.Feb_op = $('#Current-OP-Feb').text() ? parseInt($('#Current-OP-Feb').text()) : 0;
        model.Mar_op = $('#Current-OP-Mar').text() ? parseInt($('#Current-OP-Mar').text()) : 0;
        model.Apr_op = $('#Current-OP-Apr').text() ? parseInt($('#Current-OP-Apr').text()) : 0;
        model.May_op = $('#Current-OP-May').text() ? parseInt($('#Current-OP-May').text()) : 0;
        model.Jun_op = $('#Current-OP-Jun').text() ? parseInt($('#Current-OP-Jun').text()) : 0;
        model.Jul_op = $('#Current-OP-Jul').text() ? parseInt($('#Current-OP-Jul').text()) : 0;
        model.Aug_op = $('#Current-OP-Aug').text() ? parseInt($('#Current-OP-Aug').text()) : 0;
        model.UpdatedBy = _updatedBy;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/UpdateDebugTech',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update current Tech successfully!", function () {
                        LoadDebugResult()
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
})