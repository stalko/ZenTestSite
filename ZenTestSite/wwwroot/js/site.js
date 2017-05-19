// Write your Javascript code.
$(document).ready(function () {
      //called when key is pressed in textbox
      $("#ageNumber").keypress(function (e) {
         //if the letter is not digit then display error and don't type anything
         if (e.which !== 8 && e.which !== 0 && (e.which < 48 || e.which > 57)) {
            //display error message
            $("#errmsg").html("Digits Only").show().fadeOut("slow");
                   return false;
        }
       });
    });

function FromUrl() {
    $.ajax({
        type: "POST",
        url: "/Uploader/FromUrl",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ "Url": document.getElementsByName("Url")[0].value})
    }).done(function (result) {
        window.location.href = "/home/index";
        }).error(function (error) {
            alert(error);
    });
}

function FromText() {
    $.ajax({
        type: "POST",
        url: "/Uploader/FromText",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ "Text": document.getElementsByName("Text")[0].value })
    }).done(function (result) {
        window.location.href = "/home/index";
    }).error(function (error) {
        alert(error);
    });
}