// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function HideLoading() {
    setTimeout(function () {
        $('#ProgressLoadingModal').modal('hide');
    }, 700);
}

function ShowLoading(text) {
    if (typeof text === "undefined" || typeof text !== "string" || text == "") {
        text = "Processing Your Request. Please wait!!"
    }

    HidePopupModal = function (o) {
        $('#' + o).modal('hide');
    }

    ShowToastAlert = function (m, y, p) {
        $("#NotificationModal .modal-body").html(m);

        $('#NotificationModal').modal({
            keyboard: false,
            backdrop: "static"
        });

        $("#Btn_Notification_OK").unbind('click').click(function () {

            $('#NotificationModal').modal('hide');

            if (typeof y !== "undefined" && y != "" && typeof window[y] === "function") {
                window[y](p);
            }
        });

        $('#NotificationModal').on('shown.bs.modal', function (e) {
            $("#Btn_Notification_OK").focus();
        });
    }