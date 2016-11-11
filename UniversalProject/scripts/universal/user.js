$(function () {
    //var test = data;
    $("#user-list").datagrid({
        pagination: true,
        url: '/user/GetUser',
        rownumbers: true,
        columns: [[
            { field: 'FirstName', title: 'FirstName', align: 'center', width: 100 },
            { field: 'LastName', title: 'LastName', align: 'center', width: 100 },
            { field: 'Email', title: 'Email', align: 'center', width: 100 },
            { field: 'Phone', title: 'Phone', align: 'center', width: 100 }
        ]]
    });
    $('#user-list').datagrid('load');
});
//$.ajax({
//    url: "/user/GetUser",
//    type: 'get',
//    success: function (data) {
//        var test = data;
//    }
//});