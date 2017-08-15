$(function () {
    $('#switchToLogin').on('click', function () {
      
        $("#loginModal").modal('show');
        $("#registerModal").modal('hide');
    })

    $('#switchToRegister').on('click', function () {

        $("#registerModal").modal('show');
        $("#loginModal").modal('hide');
    })
})