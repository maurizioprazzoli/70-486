//$("h1:first").animate({ opacity: 0 });

//$("h1:first").fadeIn(1000);

$("h1:first").animate({ opacity: 1 });

$("h1:first").fadeOut(5000);


var productId = 1;

$.ajax({
    type: "GET",
    datatype: "json",
    contentType: "application/json",
    url: "/Product/GetDealPrice/" + productId,
    success: function (data) {
        $(".price_ajax").html(data.d);
    }
});

$.getJSON("/Product/GetDealPrice/" + productId,
function (data) {
    $(".price_getJSON").html(data.d);
});
