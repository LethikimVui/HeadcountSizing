$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-add-equipemnt-stationOrTester').on('click', '#btn-add-equipemnt-stationOrTester', AddStationData);
    $('body').off('click', '#btn-editdebugdata').on('click', '#btn-editdebugdata', UpdateStationQuantity);
    $('body').off('click', '#btn-add-downtime').on('click', '#btn-add-downtime', AddDowntime);
    $('body').off('click', '#btn-edit-downtime').on('click', '#btn-edit-downtime', UpdateDowntime);
    $('body').off('click', '#btn-save-headcount').on('click', '#btn-save-headcount', SaveHeadCount);

    var months = ['Sep', 'Oct', 'Nov', 'Dec', 'Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug']

    function Load() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);

        if (!_tranferWCId) {
            bootbox.alert('Please select WC')
        }
        else {
            LoadTableData(_tranferWCId);
            LoadResult(_tranferWCId)

        }
    }
    function LoadTableData(_tranferWCId) {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/TestTech/DataTable',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                $('#table-equipment').html(response);
                LoadEquipmentTable(_tranferWCId);
                LoadDowntime(_tranferWCId);
            }
        })
    }
    function LoadEquipmentTable(_tranferWCId) {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);

        $.ajax({
            type: 'post',
            url: '/TestTech/GetallStation',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                var data = response.result;
               
                $.each(data, function (index, value) {
                    LoadEquipemt(_tranferWCId, value.stationOrTester)
                });
            }
        })
    }

    function LoadEquipemt(_tranferWCId, _stationOrTester) {
        var model = new Object();
        model.CustId = _tranferWCId;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        model.StationOrTester = _stationOrTester;
        $.ajax({
            type: 'post',
            url: '/TestTech/GetEquipmentQuantity',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                var data = response.result;
                $.each(data, function (index, value) {

                    fy = document.getElementById("txt-fy").text;
                    $('.fy').text(fy);

                    var cell = `${index + 1}-${value.stationOrTester}`;
                    document.getElementById(`${cell}`).innerHTML = value.quantity;
                })
            }
        })
        LoadDowntime(_tranferWCId)
    }

    function LoadDowntime(_tranferWCId) {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        $.ajax({
            type: 'post',
            url: '/testtech/GetAllDowntimeByWC',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                var data = response.result;
                $.each(data, function (index, value) {
                    debugger
                    var cell = `${value.downtimeType}-${value.downtimeDetail}-${value.stationOrTester}`;
                    document.getElementById(`${cell}`).innerHTML = value.duration;
                })
            }
        })
    }
    function AddStationData() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        station = $("#txt-add-equipment-stationOrTester").val();

        $.each(months, function (index, value) {
            var model = new Object();
            var quantityText = `#txt-add-equipment-${index + 1}`;
            quantity = $(`${quantityText}`).val();
            if (quantity == "") {
                quantity = 0
            }
            model.CustId = parseInt(document.getElementById("txt-wc").value);
            model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
            model.Station = station.toUpperCase();
            model.Quantity = quantity;
            model.MonthId = index + 1;
            model.CreatedBy = document.getElementById('userinfo').getAttribute('data-user');
            debugger
            $.ajax({
                type: 'post',
                url: '/testtech/AddStationData',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
            })
        });
        Load();
    }
    function UpdateStationQuantity() {
        _monthId = $(this).attr('data-monthId');
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        $.ajax({
            type: 'post',
            url: '/TestTech/GetallStation',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    _stationOrTester = value.stationOrTester
                    SaveStationQuantity(_tranferWCId, _monthId, _stationOrTester)
                });
            }
        });

    }
    function SaveStationQuantity(_tranferWCId, _monthId, _stationOrTester) {
        var model = new Object();
        var quantityLocationt = `${_monthId}-${_stationOrTester}`;
        quantity = document.getElementById(`${quantityLocationt}`).innerHTML;
        if (quantity == "") {
            quantity = 0
        }
        model.CustId = _tranferWCId;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);

        model.MonthId = _monthId;
        model.StationOrTester = _stationOrTester;
        model.Quantity = quantity;
        model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger
        $.ajax({
            type: 'post',
            url: '/testtech/UpdateStationQuantity',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    //$(`${quantityLocation}`).attr("style", "background-color: transparent");
                    document.getElementById(`${quantityLocationt}`).setAttribute("style", "background-color: transparent");
                    LoadResult(_tranferWCId)
                }
                else if (response.statusCode != 200) {
                    alert(`Update station quantity fail for ${_stationOrTester}`);
                }
            }
        })
    }

    function AddDowntime() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        $.ajax({
            type: 'post',
            url: '/TestTech/GetallStation',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();
                    model.CustId = parseInt(document.getElementById("txt-wc").value);
                    model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
                    model.StationOrTester = value.stationOrTester;
                    model.DowntimeType = $('#txt-dowtimetype').val();
                    model.DowntimeDetail = $('#add-DowntimeDetail').val();
                    var durationLocation = `add-downtime-${value.stationOrTester}`;
                    duration = document.getElementById(`${durationLocation}`).value;
                    if (duration == "") {
                        duration = 0;
                    }
                    model.Duration = duration;
                    model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
                    debugger
                    $.ajax({
                        type: 'post',
                        url: '/testtech/UpdateDowntime',
                        dataType: 'json',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (response) {
                            if (response.statusCode == 200) {
                                Load();
                            }
                            else if (response.statusCode != 200) {
                                alert(`Update downtime fail for ${_stationOrTester}`);
                            }

                        }
                    })
                });
            }
        })
    }
    function UpdateDowntime() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        _downtimetype = $(this).attr('data-downtimeType');
        _downtimedetail = $(this).attr('data-downtimeDetail');
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        $.ajax({
            type: 'post',
            url: '/TestTech/GetallStation',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();

                    _stationOrTester = value.stationOrTester;
                    model.CustId = _tranferWCId;
                    model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);

                    model.StationOrTester = _stationOrTester;
                    model.DowntimeType = _downtimetype;
                    model.DowntimeDetail = _downtimedetail;
                    var durationLocation = `${_downtimetype}-${_downtimedetail}-${_stationOrTester}`;
                    debugger

                    _duration = document.getElementById(`${durationLocation}`).innerHTML;
                    if (_duration == "") {
                        _duration = 0;
                    }
                    model.Duration = _duration;
                    model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
                    $.ajax({
                        type: 'post',
                        url: '/testtech/UpdateDowntime',
                        dataType: 'json',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (response) {
                            if (response.statusCode == 200) {
                                document.getElementById(`${durationLocation}`).setAttribute("style", "background-color: transparent");
                                LoadResult(_tranferWCId)
                            }
                            else if (response.statusCode != 200) {
                                alert(`Update downtime fail for ${_stationOrTester}`);
                            }
                        }
                    })
                });
            }
        })
    }


    function SaveHeadCount() {
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        _updatedBy = document.getElementById('userinfo').getAttribute('data-user');

        var model = new Object();
        model.CustId = _tranferWCId;
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        model.Sep = $('#hc-Sep').text();
        model.Oct = $('#hc-Oct').text();
        model.Nov = $('#hc-Nov').text();
        model.Dec = $('#hc-Dec').text();
        model.Jan = $('#hc-Jan').text();
        model.Feb = $('#hc-Feb').text();
        model.Mar = $('#hc-Mar').text();
        model.Apr = $('#hc-Apr').text();
        model.May = $('#hc-May').text();
        model.Jun = $('#hc-Jun').text();
        model.Jul = $('#hc-Jul').text();
        model.Aug = $('#hc-Aug').text();
        model.UpdatedBy = _updatedBy;
        debugger
        $.ajax({
            type: 'post',
            url: '/testtech/UpdateTestTech',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update current Tech successfully!", function () {
                        LoadResult(_tranferWCId)
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
    function LoadResult(_tranferWCId) {
        var model = new Object();
        model.CustId = parseInt(document.getElementById("txt-wc").value);
        model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        debugger
        $.ajax({
            type: 'post',
            url: '/TestTech/GetFinalResult_partialview',
            data: JSON.stringify(model),
            contentType : 'application/json;charset=utf-8',
            success: function (response) {
                debugger
                $('#table-result').html(response);
                $.each(months, function (index, value) {
                    var roudupTech = `#roudup-${value}`;
                    var lockedTech = `#hc-${value}`;
                    if (parseInt($(`${roudupTech}`).text()) < parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: #FFFFB1");
                    }
                    else if (parseInt($(`${roudupTech}`).text()) > parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: red");
                    }
                    else if (parseInt($(`${roudupTech}`).text()) === parseInt($(`${lockedTech}`).text())) {
                        $(`${lockedTech}`).attr("style", "background-color: #00C851");
                    }
                })
                var link = $("<a>");
                link.attr("onclick", "tablesToExcel(['tbl-equipment', 'tbl-downtime', 'tbl-result'], ['equipment', 'downtime', 'result'], 'TestTechnician.xls', 'Excel')");

                link.attr("class", "btn btn-success");
                link.text("Export");
                link.addClass("link");

                $(".box").html(link);
            }
        })
    }
})