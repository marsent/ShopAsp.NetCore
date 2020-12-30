// Call the dataTables jQuery plugin

$(document).ready(function () {
    loadInvoices();
});

function loadInvoices() {
    dataTable = $('#Invoices_load').DataTable({
        "ajax": {
            "url": "/admin/getallinvoices",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "billId", "width": "5%" },
            { "data": "receiver", "width": "10%" },
            { "data": "phone", "width": "10%" },

            { "data": "address", "width": "25%" },
            { "data": "date", "width": "15%" },

            {
                "data": "status",
                "width": "10%",
                "render": function (data, type, row) {
                    if (data == "chua van chuyen") {
                        return "Chưa vận chuyển"
                    }
                    return "Đã vận chuyển";
                }
            },
            {
                "data": "pay",
                "width": "10%",
                "render": function (data, type, row) {
                    if (data == 1) {
                        return "Đã thanh toán"
                    }
                    return "Chưa thanh toán";
                }
            },

            {
                "data": "total",
                "width": "10%",
                "render": function (data, type, row) {
                    var formatter = new Intl.NumberFormat('vi-VN', {
                        style: 'currency',
                        currency: 'VND',
                    });

                    return formatter.format(data);
                }
            },
            {
                "data": "billId",
                "render": function (data) {
                    return `<div class="text-center atc">

                         <input type="hidden" value="${data}"/>
                        <a href="/admin/UpsertBill?id=${data}"  style='cursor:pointer; width:70px;'>
                           <i class="fa fa-edit"></i>
                        </a>
                        &nbsp;
                        <a  style='cursor:pointer; width:70px;'
                            onclick=Delete('/Admin/DeleteBill?id='+${data}) >
                           <i class="fa fa-trash"></i>
                        </a>
                        </div>`;
                }, "width": "20%"
            }
        ],
        "language": {
            "emptyTable": "Không có dữ liệu",
            "search": "Tìm kiếm:",
            "info": "Hiển thị từ _START_ đến _END_ trển _TOTAL_ Hóa đơn",
            "infoEmpty": "",
            "loadingRecords": "Đang tải dữ liệu...",
            "paginate": {
                "first": "<<",
                "last": ">>",
                "next": ">",
                "previous": "<"
            },
            "lengthMenu": "Hiện _MENU_ Hóa đơn",
        },
        "lengthMenu": [[10, 25, 50, -1], [10, 25, 50, "All"]],
        "width": "100%"
    });
}

function Delete(url) {
    Swal.fire({
        title: "Bạn có chắc muốn xóa",
        text: "Sau khi xóa dữ liệu sẽ không được khôi phục",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: 'Đồng ý',
        cancelButtonText: 'Hủy',
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    const Toast = Swal.mixin({
                        toast: true,
                        position: 'top-end',
                        showConfirmButton: false,
                        timer: 3000,
                        timerProgressBar: true,
                        didOpen: (toast) => {
                            toast.addEventListener('mouseenter', Swal.stopTimer)
                            toast.addEventListener('mouseleave', Swal.resumeTimer)
                        }
                    })
                    if (data.success) {
                        Toast.fire({
                            icon: 'success',
                            title: 'Xóa sản phẩm thành công'
                        })
                        dataTable.ajax.reload();
                    }
                    else {
                        Toast.fire({
                            icon: 'error',
                            title: 'Xóa sản phẩm thất bại'
                        })
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


$(document).ready(() => {
    var formatter = new Intl.NumberFormat('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    $("#Total").html(formatter.format($("#Total").text()))
})

$("#Total").change(() => {
    var formatter = new Intl.NumberFormat('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    var total = $(this).text()
    $(this).html(formatter.format(total));
})