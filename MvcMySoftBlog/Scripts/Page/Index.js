function getdata() {
    $.post("/Home/Rt", { d: 4 }, function (data) {
        debugger;
        alert(data);
    },"json");
}

$(document).ready(function () {
    getdata();
});