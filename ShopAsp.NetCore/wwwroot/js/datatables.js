// Call the dataTables jQuery plugin

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/admin/getall",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "10%" },
            { "data": "brand", "width": "5%" },
            { "data": "price", "width": "10%" },
            {
                "data": "imageUrl", "width": "30%",
                "render": function (data, type, row) {
                    return ` <img class="zoom" src="\\Public\\Images\\${data}" width='100%'/>`;
                }
            },
            { "data": "dateCreate", "width": "10%" },
            { "data": "dateUpdate", "width": "10%" },
            {
                "data": "description",
                "width": "30%",
                "render": function (data, type, row) {
                    if (data != null) {
                        return type === 'display' && data.length > 30 ?
                            data.substr(0, 30) + '…' :
                            data;
                    }
                    return data;
                }
            },
            {
                "data": "OutstandingProductsutstandingProducts",
                "width": "5%",
                "render": function (data) {
                    if (data == true) return `<input onchange=UpdateCheck(this,"OutstandingProducts") type="checkbox" value=${data} checked/>`
                    else return `<input onchange=UpdateCheck(this,"OutstandingProducts") type="checkbox" value=${data}/>`
                }
            },
            {
                "data": "hotProduct", "width": "5%", "render": function (data) {
                    if (data == true) return `<input onchange=UpdateCheck(this,"HotProduct") type="checkbox" value=${data} checked/>`
                    else return `<input onchange=UpdateCheck(this,"HotProduct") type="checkbox" value=${data} />`
                }
            },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center atc">

                         <input type="hidden" value="${data}"/>
                        <a href="/admin/Upsert?id=${data}"  style='cursor:pointer; width:70px;'>
                           <i class="fa fa-edit"></i>
                        </a>
                        &nbsp;
                        <a  style='cursor:pointer; width:70px;'
                            onclick=Delete('/admin/Delete?id='+${data}) >
                           <i class="fa fa-trash"></i>
                        </a>
                        </div>`;
                }, "width": "20%"
            }
        ],
        "language": {
            "emptyTable": "Không có dữ liệu",
            "search": "Tìm kiếm:",
            "info": "Hiển thị từ _START_ đến _END_ trển _TOTAL_ sản phẩm",
            "infoEmpty": "",
            "loadingRecords": "Đang tải dữ liệu...",
            "paginate": {
                "first": "<<",
                "last": ">>",
                "next": ">",
                "previous": "<"
            },
            "lengthMenu": "Hiện _MENU_ sản phẩm",
        },
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]],
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Bạn có chắc muốn xóa",
        text: "Sau khi xóa dữ liệu sẽ không được khôi phục",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

function UpdateCheck(data, colName) {
    check = data.checked;
    id = parseInt(data.closest("tr").children[9].children[0].children[0].value);
    url = "admin/UpdateCheck";

    if (check == true) {
        $.ajax({
            type: "POST",
            url: url,
            data: { id: id, data: true, colName: String(colName) },
            datatype: "JSON",
            success: function (data) {
                console.log(data.message)
            },
            error: function (data) {
                swal({
                    title: "Không thể cập nhật dữ liệu",
                    text: data.message,
                    icon: "danger",
                    dangerMode: true
                })
            }
        })
    }
    else {
        $.ajax({
            type: "POST",
            url: url,
            data: { id: id, data: false, colName: String(colName) },
            datatype: "JSON",
            success: function (data) {
                console.log(data.message)
            },
            error: function (data) {
                swal({
                    title: "Không thể cập nhật dữ liệu",
                    text: data.message,
                    icon: "danger",
                    dangerMode: true
                })
            }
        })
    }
}
