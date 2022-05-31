
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
            LoadResult(_tranferWCId);
        }
    }
    function LoadTableData(_tranferWCId) {
        $.ajax({
            type: 'post',
            url: '/TestOperator/DataTable',
            data: { wcId: _tranferWCId },
            success: function (response) {
                $('#table-equipment').html(response);
                LoadEquipmentTable(_tranferWCId);
                LoadDowntime(_tranferWCId);
            }
        })
    }
    function LoadEquipmentTable(_tranferWCId) {
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetallStation',
            data: { wcId: _tranferWCId },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    debugger
                    LoadEquipemt(_tranferWCId, value.stationOrTester)
                });
            }
        })
    }

    function LoadEquipemt(_tranferWCId, _stationOrTester) {
        var model = new Object();
        model.CustId = _tranferWCId;
        model.StationOrTester = _stationOrTester;
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetEquipmentQuantity',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                var data = response.result;
                $.each(data, function (index, value) {
                    var cell = `${index + 1}-${value.stationOrTester}`;
                    document.getElementById(`${cell}`).innerHTML = value.quantity;
                })
            }
        })
        LoadDowntime(_tranferWCId)
    }

    function LoadDowntime(_tranferWCId) {
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetAllDowntimeByWC',
            data: { wcId: _tranferWCId },
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
            debugger
            if (quantity == "") {
                quantity = 0
            }
            model.CustId = _tranferWCId;
            model.Station = station.toUpperCase();
            model.Quantity = quantity;
            model.MonthId = index + 1;
            model.CreatedBy = document.getElementById('userinfo').getAttribute('data-user');
            debugger
            $.ajax({
                type: 'post',
                url: '/TestOperator/AddStationData',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
            })
        });
        Load();
    }
    function UpdateStationQuantity() {
        _monthId = $(this).attr('data-monthId');
        _tranferWCId = parseInt(document.getElementById("txt-wc").value);
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetallStation',
            data: { wcId: _tranferWCId },
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
        model.MonthId = _monthId;
        model.StationOrTester = _stationOrTester;
        model.Quantity = quantity;
        model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger
        $.ajax({
            type: 'post',
            url: '/TestOperator/UpdateStationQuantity',
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
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetallStation',
            data: { wcId: _tranferWCId },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();
                    model.CustId = _tranferWCId;
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
                        url: '/TestOperator/UpdateDowntime',
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
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetallStation',
            data: { wcId: _tranferWCId },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();

                    _stationOrTester = value.stationOrTester;
                    model.CustId = _tranferWCId;
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
                        url: '/TestOperator/UpdateDowntime',
                        dataType: 'json',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (response) {
                            if (response.statusCode == 200) {
                                document.getElementById(`${durationLocation}`).setAttribute("style", "background-color: transparent");
                                LoadTestResult(_tranferWC)
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
            url: '/TestOperator/UpdateTestTech',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update successfully!", function () {
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
        $.ajax({
            type: 'post',
            url: '/TestOperator/GetFinalResult_partialview',
            data: { wcId: _tranferWCId },
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
                link.attr("onclick", "tablesToExcel(['tbl-equipment', 'tbl-downtime', 'tbl-result'], ['equipment', 'downtime', 'result'], 'TestOperator.xls', 'Excel')");

                link.attr("class", "btn btn-success");
                link.text("Export");
                link.addClass("link");

                $(".box").html(link);
            }
        })
    }
})