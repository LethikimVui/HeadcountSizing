$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Search);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);

    user = document.getElementById('userinfo').getAttribute('data-user');
    //name = document.getElementById('userinfo').getAttribute('data-display-name');
    //email = document.getElementById('userinfo').getAttribute('data-email');

    function Search() {
        custId = parseInt($('#txt-wc').val());
        fiscalYearId = parseInt($('#txt-fy').val());
        var model = new Object();
        model.CustId = custId
        model.FiscalYearId = fiscalYearId
        debugger
        $.ajax({
            type: 'post',
            url: '/testtech/Test_Partial',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                debugger
                $("#table-result").html(response);
            }
        })
    }

    function Add() {
        //var model = new Object();
        //model.CustId = parseInt(document.getElementById("txt-wc").value);
        //model.FiscalYearId = parseInt(document.getElementById("txt-fy").value);
        custId = parseInt($('#txt-wc').val());
        fiscalYearId = parseInt($('#txt-fy').val());
        var model = new Object();
        model.CustId = custId
        model.FiscalYearId = fiscalYearId
        $.ajax({
            type: 'post',
            url: '/TestTech/GetallStation',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',

            success: function (response) {
                var data = response.result;

                $.each(data, function (index, value) {
                    AddEquipment( value.stationOrTester)
                });
            }
        })
    }

    function AddEquipment(_station) {
        custId = parseInt($('#txt-wc').val());
        fiscalYearId = parseInt($('#txt-fy').val());
        //cell = 'txt-' && _station;
        quantity = parseInt(document.getElementById(_station).value);
        var model = Object();
        model.Station = _station;
        model.CustId = custId
        model.FiscalYearId = fiscalYearId
        model.Quantity = quantity
        model.UpdatedBy = user
        debugger
        $.ajax({
            type: 'post',
            url: '/testtech/Test_Equipment_add',
            data: JSON.stringify(model),
            dataType: 'json',
            success: function (response) {
                debugger
            }
            
        })
    }

})