$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);

    $('body').off('click', '#btn-editrawdata').on('click', '#btn-editrawdata', LoadSinglelRawData);
    $('body').off('click', '#btn-save-rawdata').on('click', '#btn-save-rawdata', SaveRawData);

    $('body').off('click', '#btn-editdebugdata').on('click', '#btn-editdebugdata', LoadSingleDebugData);
    $('body').off('click', '#btn-save-debugdata').on('click', '#btn-save-debugdata', SaveDebugData);
    

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
            $.ajax({
                type: 'post',
                url: '/debug/GetDebugRawDataByWC',
                data: { wc: _tranferWC },
                success: function (response) {

                    var data = response.result;
                    debugger

                    if (data == null) {
                        //bootbox.alert(`Raw data not found for ${_tranferWC}?`)
                    }
                    else {
                        LoadDebugRawData(_tranferWC)
                    }
                }
            })
            $.ajax({
                type: 'post',
                url: '/debug/GetDebugDataByWCandMonth',
                data: { wc: _tranferWC },
                success: function (response) {

                    var data = response.result.length;
                    debugger

                    if (data == 0) {
                        //bootbox.alert(`Debug data not found for ${_tranferWC}?`)
                    }
                    else {
                        LoadDebugData(_tranferWC)
                    }
                }
            })
        }

        $.ajax({
            type: 'post',
            url: '/debug/GetDebugResul',
            data: { wc: _tranferWC },
            success: function (response) {

                var data = response.result.length;
                debugger

                if (data == 0) {
                    bootbox.alert(`input data for ${_tranferWC}?`)
                }
                else {
                    LoadDebugResult(_tranferWC)
                }
            }
        })
    }

    function LoadDebugRawData(_tranferWC) {
        //_tranferWC = $("#txt-wc").val();    
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetDebugRawDataByWC_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                $('#table-rawdata').html(response);
            }
        })
    }
    function LoadDetailRawData() {
        _tranferWC = $(this).attr('data-rawdata');
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetSingleDebugRawDataByWCandMonthAsync',
            data: { wc: _tranferWC },

            success: function (response) {
                var data = response.result;
                debugger
                $('#txt-wcmodal').text(data.wc);
                $('#txt-month').text(data.month);
                $('#txt-WorkingDayPerMonth').val(data.workingDayPerMonth);
                $('#txt-WorkingHourPerShift').val(data.workingHourPerShift)
                $('#txt-ShifPatten').val(data.shifPatten);
                $('#txt-WorkEfficiency').val(data.workEfficiency);
                $('#txt-TotalLoadingForDebug').val(data.totalLoadingForDebug);
                $('#txt-UpdateBy').val(data.updateBy);
            }
        })
    }
    function LoadSinglelRawData() {
        var model = new Object();
        model.Month = $(this).attr('data-month');
        model.Wc = $("#txt-wc").val();
        debugger
        $.ajax({
            type: 'post',
            url: '/debug/GetSingleDebugRawDataByWCandMonthAsync',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                var data = response.result;
                debugger
                $('#txt-wcmodal').text(data.wc);
                $('#txt-month').text(data.month);
                $('#txt-WorkingDayPerMonth').val(data.workingDayPerMonth);
                $('#txt-WorkingHourPerShift').val(data.workingHourPerShift)
                $('#txt-ShifPatten').val(data.shifPatten);
                $('#txt-WorkEfficiency').val(data.workEfficiency);
                $('#txt-TotalLoadingForDebug').val(data.totalLoadingForDebug);
                $('#txt-UpdateBy').val(data.updateBy);
            }
        })
    }
    function SaveRawData() {
        if ($('#frm-save').valid()) {

            var model = new Object();
            debugger
            model.Wc = $('#txt-wcmodal').text();
            model.Month = $('#txt-month').text();
            model.WorkingDayPerMonth = $('#txt-WorkingDayPerMonth').val();
            model.WorkingHourPerShift = $('#txt-WorkingHourPerShift').val()
            model.ShifPatten = $('#txt-ShifPatten').val();
            model.WorkEfficiency = $('#txt-WorkEfficiency').val();
            model.TotalLoadingForDebug = $('#txt-TotalLoadingForDebug').val();
            model.UpdateBy = $('#txt-UpdateBy').val();

            $.ajax({
                type: 'post',
                url: '/debug/UpdateDebugRawData',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    debugger
                    if (response.statusCode == 200) {
                        bootbox.alert("Update successfully!", function () {
                            $('#modal-debugrawdata').modal('hide')
                            Load();
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
            $('#modal-debugrawdata').modal('hide');
        }
    }

    function LoadDebugData(_tranferWC) {
        //_tranferWC = $("#txt-wc").val();    

        $.ajax({
            type: 'post',
            url: '/debug/GetDebugDataByWCandMonth_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                $('#table-debugdata').html(response);
            }
        })
    }
    function LoadSingleDebugData() {
        debugger

        _tranferId = $(this).attr('data-debugdata');;//$('#btn-editdebugdata').data('debugdata');

        $.ajax({
            type: 'post',
            url: '/debug/GetSingleDebugDataByIdAsync',
            data: { id: _tranferId },

            success: function (response) {
                var data = response.result;
                debugger
                $('#frm-save-debugdata').attr("data-id", _tranferId);
                $('#txt-station').text(data.station);
                $('#txt-DebugHitrateYield').val(data.debugHitrateYield);
                $('#txt-NormalRate').val(data.normalRate)
                $('#txt-DebugTimeForNormalBoard').val(data.debugTimeForNormalBoard);
                $('#txt-DebugTimeForHardcoreBoard').val(data.debugTimeForHardcoreBoard);
                $('#txt-FinalYield').val(data.finalYield);
                $('#txt-LastUpdateBy').text(data.updateBy);
            }
        })
    }
    function SaveDebugData() {
        if ($('#frm-save-debugdata').valid()) {
            var model = new Object();
            debugger
            model.Id = $('#frm-save-debugdata').attr('data-id');//$('#frm-save-debugdata').data('id');
            model.DebugHitrateYield = $('#txt-DebugHitrateYield').val();
            model.NormalRate = $('#txt-NormalRate').val()
            model.DebugTimeForNormalBoard = $('#txt-DebugTimeForNormalBoard').val();
            model.DebugTimeForHardcoreBoard = $('#txt-DebugTimeForHardcoreBoard').val();
            model.FinalYield = $('#txt-FinalYield').val();
            model.UpdateBy = $('#txt-LastUpdateBy').text();


            $.ajax({
                type: 'post',
                url: '/debug/UpdateSingleDebugDataById',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    debugger
                    if (response.statusCode == 200) {
                        bootbox.alert("Update debug data successfully!", function () {
                            $('#modal-debugdata').modal('hide')
                            Load();
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
            $('#modal-debugrawdata').modal('hide');
        }
    }

    function LoadDebugResult(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/debug/GetDebugResult_partialview',
            data: { wc: _tranferWC },
            success: function (response) {
                debugger

                $('#table-debugresult').html(response);
            }
        })
    }
})