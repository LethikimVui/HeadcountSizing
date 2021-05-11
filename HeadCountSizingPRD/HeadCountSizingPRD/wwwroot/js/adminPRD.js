$(document).ready(function () {
    $('body').off('click', '#btn-search-input').on('click', '#btn-search-input', SearchName);
    $('body').off('click', '#btn-add-user').on('click', '#btn-add-user', AddUserRole);
    $('body').off('click', '#btn-delete-user').on('click', '#btn-delete-user', Delete);
  
    function SearchName() {
        _tranferId = $('#txt-search-input').val();
        debugger
        $.ajax({
            type: 'post',
            url: '/hcs/admin/GetUserRoleByNTlogin',
            data: { Ntlogin: _tranferId},
            success: function (response) {
                debugger
                data = response.result;
                if (!data) {
                    $.ajax({
                        type: 'post',
                        url: '/hcs/admin/GetProperty',
                        data: { ntid: _tranferId, info: 'displayname' },
                        success: function (response) {
                            debugger
                            if (response) {
                                $('#txt-userName').text(response);
                                $('#txt-Ntlogin').val(_tranferId);
                                $('#modal-search').modal('hide');
                            }
                            else {
                                bootbox.alert("Name is not found");
                            }
                        }
                    })
                }
                else {
                    bootbox.alert("Duplicate user found");
                }               
            }
        })
        
    }
    function AddUserRole() {
        var model = new Object();
        model.Ntlogin = $('#txt-Ntlogin').val();
        model.UserName = $('#txt-userName').text();
        model.RoleId = parseInt(document.getElementById("txt-roleId").value);
        model.PlantId = 1 // parseInt(document.getElementById("txt-wc").value);
        model.CustId = parseInt(document.getElementById("txt-custId").value);
        model.CreatedBy = document.getElementById('userinfo').getAttribute('data-user');
        debugger

        $.ajax({
            type: 'post',
            url: '/hcs/admin/AddUserRole',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                if (response.statusCode == 200) {
                    bootbox.alert("Update successfully!", function () {
                        location.reload(true);
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

    function Delete() {
        _id = $(this).attr('data-id');
        _updatedBy = document.getElementById('userinfo').getAttribute('data-user');
        ntlogin = $(this).attr('data-ntlogin');
        debugger
        $.ajax({
            type: 'post',
            url: '/hcs/admin/DeleteUserRole',
            data: { roleId: _id, updatedBy: _updatedBy},
            success: function (response) {

                var data = response.statusCode;
                if (data == 200) {
                    bootbox.alert(`${ntlogin} is deleted`, function () {
                        location.reload(true);
                    })
                }
                else {
                    bootbox.alert("Error");
                }
            }
        })
    }
})