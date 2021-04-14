
$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-editdebugdata').on('click', '#btn-editdebugdata', UpdateStationQuantity);
    $('body').off('click', '#btn-save-headcount').on('click', '#btn-save-headcount', SaveHeadCount);
    $('body').off('click', '#btn-add-equipemnt-stationOrTester').on('click', '#btn-add-equipemnt-stationOrTester', AddStationData);
    $('body').off('click', '#btn-add-downtime').on('click', '#btn-add-downtime', AddDowntime);
    $('body').off('click', '#btn-edit-downtime').on('click', '#btn-edit-downtime', UpdateDowntime);

    var months = ['Sep', 'Oct', 'Nov', 'Dec', 'Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug']

    function Load() {
        _tranferWC = $("#txt-wc").val();
        if (_tranferWC == "0") {
            bootbox.alert('Please select WC')
        }
        else {
            LoadTestResult(_tranferWC)
            LoadTHead(_tranferWC);     
        }
    }

    function LoadEquipmentTable(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetallStation',
            data: { wc: _tranferWC },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    LoadEquipemt(_tranferWC, value.stationOrTester)
                });
            }
        })
    }
    function LoadTHead(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetTestData',
            data: { wc: _tranferWC },
            success: function (response) {
                $('#table-equipment').html(response);
                LoadEquipmentTable(_tranferWC);
                LoadDowntime(_tranferWC);
            }
        })
    }
    function LoadEquipemt(_tranferWC, _stationOrTester) {
        var model = new Object();
        model.wc = _tranferWC;
        model.stationOrTester = _stationOrTester;
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/EquipmentQuantity',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                var data = response.result;
                $.each(data, function (index, value) {
                    var cell = `${value.month}-${value.stationOrTester}`;
                    document.getElementById(`${cell}`).innerHTML = value.quantity;
                })
            }
        })
        LoadDowntime(_tranferWC)
    }

    function LoadDowntime(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/testtech/GetAllDowntimeByWC',
            data: { wc: _tranferWC },
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
        _transferWC = $("#txt-wc").val();
        station = $("#txt-add-equipment-stationOrTester").val();

        $.each(months, function (index, value) {
            var model = new Object();
            var quantityText = `#txt-add-equipment-${value}`;
            quantity = $(`${quantityText}`).val();
            if (quantity == "") {
                quantity = 0
            }
            model.Month = value;
            model.WC = _transferWC;
            model.Station = station.toUpperCase();
            model.Quantity = quantity;
            model.MonthID = index + 1;
            model.CreatedBy = document.getElementById('userinfo').getAttribute('data-user');
            $.ajax({
                type: 'post',
                url: '/hcs/testtech/AddStationData',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
            })
        });
        Load();
    }
    function UpdateStationQuantity() {
        _month = $(this).attr('data-month');
        _tranferWC = $("#txt-wc").val();
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetallStation',
            data: { wc: _tranferWC },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    _stationOrTester = value.stationOrTester
                    SaveStationQuantity(_tranferWC, _month, _stationOrTester)
                });
            }
        });

    }
    function SaveStationQuantity(_tranferWC, _month, _stationOrTester) {

        var model = new Object();
        var quantityLocationt = `${_month}-${_stationOrTester}`;
        quantity = document.getElementById(`${quantityLocationt}`).innerHTML;
        if (quantity == "") {
            quantity = 0
        }
        model.Wc = _tranferWC;
        model.Month = _month;
        model.StationOrTester = _stationOrTester;
        model.Quantity = quantity;
        model.UpdatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger
        $.ajax({
            type: 'post',
            url: '/hcs/testtech/UpdateStationQuantity',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    //$(`${quantityLocation}`).attr("style", "background-color: transparent");
                    document.getElementById(`${quantityLocationt}`).setAttribute("style", "background-color: transparent");
                    LoadTestResult(_tranferWC)
                }
                else if (response.statusCode != 200) {
                    alert(`Update station quantity fail for ${_stationOrTester}`);
                }
            }
        })
    }

    function AddDowntime() {
        _transferWC = $("#txt-wc").val();
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetallStation',
            data: { wc: _tranferWC },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();
                    model.WC = _transferWC;
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
                        url: '/hcs/testtech/UpdateDowntime',
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
        _transferWC = $("#txt-wc").val();
        _downtimetype = $(this).attr('data-downtimeType');
        _downtimedetail = $(this).attr('data-downtimeDetail');
       
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetallStation',
            data: { wc: _tranferWC },
            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    var model = new Object();
                    
                    _stationOrTester = value.stationOrTester;                   
                    model.WC = _transferWC;
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
                        url: '/hcs/testtech/UpdateDowntime',
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
        _transferWC = $("#txt-wc").val();
        _updatedBy = document.getElementById('userinfo').getAttribute('data-user');

        var model = new Object();
        model.Wc = _transferWC;
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
            url: '/hcs/testtech/UpdateTestTech',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update current Tech successfully!", function () {
                        LoadTestResult(_transferWC)
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
    function LoadTestResult(_tranferWC) {
        $.ajax({
            type: 'post',
            url: '/hcs/TestTech/GetFinalResult_partialview',
            data: { wc: _tranferWC },
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
                link.attr("onclick", "tablesToExcel([ 'tbl-testresult'], ['result'], 'TestTech.xls', 'Excel')");
                link.attr("class", "btn btn-success");
                link.text("Export");
                link.addClass("link");

                $(".box").html(link);
            }
        })
    }
})