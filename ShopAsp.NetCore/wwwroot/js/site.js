$(document).ready(function () {
    addAdmin();
});


function addAdmin(){

    $("#addAdmin").click(async () => {
        const { value: email } = await Swal.fire({
            title: 'Nhập email',
            input: 'email',
            showCloseButton: true,
            inputPlaceholder: 'Email'
        })
        if (email) {
            await $.ajax({
                url: "/admin/AddAdmin",
                type: "POST",
                dataType: "Json",
                data: { email: email },
                success: async function (data) {
                    if (data.success == true) {
                        Swal.fire({
                            icon: 'success',
                            title: 'Thêm tài khoản thành công',
                        })
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Thêm tài khoản thất bại',
                            text:'Không tìm thấy Email'
                        })
                    }
                }

            })
        }

    })
}