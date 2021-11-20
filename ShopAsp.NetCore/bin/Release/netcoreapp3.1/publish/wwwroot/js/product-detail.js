function addToCart(userId, itemId, quantity) {
    if (userId != null) {
        $.ajax({
        type: 'post',
        url: '../gio-hang/xu-ly-hang.php',
        data: {
            userId: userId,
            itemId: itemId,
            quantity: quantity
        },
        success: function(data) {
            $('#totalItems').html(data);
            console.log(data);
            $(function(){
                alert("Sản phẩm đã được thêm vào giỏ");
            });
        }
        });
    }
}
