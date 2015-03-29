function getdata() {
    //    $.post("/Home/Rt", { d: 4 }, function (data) {

    //    });
}

$(document).ready(function () {
    $("a").hover(function () {
        //over
        $(this).addClass("btn-success");
        console.log("in:" + $(this).attr("class"));
    }, function () {
        //move out
        $(this).removeClass("btn-success");
        console.log("out:" + $(this).className);
    });
    $("#btnPostNew").click(function () {
        alert(44);
    });
});

var opr = {    
    
};