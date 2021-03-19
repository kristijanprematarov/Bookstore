
$(document).ready(function () {
    console.log('Document is ready!!!');
});

$("#AuthorID").change(function () {

    //var optionSelected = $("option:selected", this);
    var optionSelected = $(this).find(":selected"); 
    console.log(optionSelected)

    //first
    var optionName1 = optionSelected[0].innerHTML;
    console.log("optionName1 is:" + optionName1)

    //sec
    var optionName2 = optionSelected.text();
    console.log("optionName2 is:" + optionName2)

    $("#AuthorName").val(optionName1).removeAttr("hidden");
    console.log($("#AuthorName").val())

});

$("#CategoryID").change(function () {

    //var optionSelected = $("option:selected", this);
    var optionSelected = $(this).find(":selected");
    console.log(optionSelected)

    //first
    var optionName1 = optionSelected[0].innerHTML;
    console.log("optionName1 is:" + optionName1)

    //sec
    var optionName2 = optionSelected.text();
    console.log("optionName2 is:" + optionName2)

    $("#CategoryName").val(optionName1).removeAttr("hidden");
    console.log($("#CategoryName").val())

});

$("#PublisherID").change(function () {

    //var optionSelected = $("option:selected", this);
    var optionSelected = $(this).find(":selected");
    console.log(optionSelected)

    //first
    var optionName1 = optionSelected[0].innerHTML;
    console.log("optionName1 is:" + optionName1)

    //sec
    var optionName2 = optionSelected.text();
    console.log("optionName2 is:" + optionName2)

    $("#PublisherName").val(optionName1).removeAttr("hidden");
    console.log($("#PublisherName").val())


});

//$(document).ready(function () {

//    $("#Result").click(function () {

//        $.ajax({
//            type: "POST",
//            url: "",
//            data: { someParametar: "some value" },
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (msg) {
//                //Replace the div's content with the page methods return
//                $("Result").text(msg.d);
//            }
//        });

//    });

//});




