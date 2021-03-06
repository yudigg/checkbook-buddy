﻿$(document).ready(function () {
    var orderId = $("#orderId").val();
    $("#foofileuploader").uploadFile({
        url: "../Home/UploadFile?orderId=" + orderId + "&person=" + 7,
        statusBarWidth: '380',
        dragdropWidth: '380',
        showDelete: true,
        autoSubmit: true,
        showProgress: true,
        showPreview: false,

        deleteCallback: function (data, pd) {
            $.post("../Home/DeleteFile?url=" + data.url,
                function (resp, textStatus, jqXHR) {
                    //Show Message
                    console.log(resp, textStatus);
                    alert(resp.msg);
                    pd.statusbar.hide(); //You choice.
                });
        }

    });

});