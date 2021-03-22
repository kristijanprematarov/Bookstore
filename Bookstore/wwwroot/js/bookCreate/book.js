//$(document).ready(function () { });

$(document).ready(function () {
    console.log('Document is ready!!!');

    //CREATE JQ KRIS
    $("#AuthorID option").first().attr("hidden", "true");

    $("#PublisherID option").first().attr("hidden", "true");

    $("#CategoryID option").first().attr("hidden", "true");

});


$("#AuthorID").change(function () {

    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    //NACIN 1
    var optionName = optionSelected[0].innerHTML;
    console.log("OptionName1 :" + optionName)

    //NACIN 2
    var optionName2 = optionSelected.text();
    console.log("OptionName2 :" + optionName2)

    $("#AuthorName").val(optionName);
    console.log($("#AuthorName").val());
});

$("#PublisherID").change(function () {

    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    //NACIN 1
    var optionName = optionSelected[0].innerHTML;
    console.log("OptionName1 :" + optionName)

    //NACIN 2
    var optionName2 = optionSelected.text();
    console.log("OptionName2 :" + optionName2)

    $("#PublisherName").val(optionName);
    console.log($("#PublisherName").val())
});

$("#CategoryID").change(function () {

    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    //NACIN 1
    var optionName = optionSelected[0].innerHTML;
    console.log("OptionName1 :" + optionName)

    //NACIN 2
    var optionName2 = optionSelected.text();
    console.log("OptionName2 :" + optionName2)

    $("#CategoryName").val(optionName);
    console.log($("#CategoryName").val())
});




//$(document).ready(function () {
//    // Add the page method call as an onclick handler for the div.
//    $("#Result").click(function () {
//        $.ajax({
//            type: "POST",
//            url: "",
//            data: { someParametar: "some value" },
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (msg) {
//                // Replace the div's content with the page method's return.
//                $("#Result").text(msg.d);
//            }
//        });
//    });
//});


$("#addNewAuthor").click(function () {
    console.log("modal button author add new author");

    //Note: propertinjata so gi polnime mora da se istite od Entitetskata klasa !!!
    var data =
    {
        Name: $("#AuthorNameDTO").val(),
        Country: $("#AuthorCountryDTO").val(),
        DateBirth: $("#AuthorDateBirthDTO").val(),
        ShortDescription: $("#AuthorShortDescriptionDTO").val(),
        Language: $("#AuthorLanguageDTO").val(),
        Gender: $("#AuthorGenderDTO").val(),
    };

    $.ajax({
        type: "POST",
        url: "/Author/CreateAuthorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            //AUTHOR ID ... na selectot zalepi mu go kreiraniot avtor kako nova option
            //<option value="value">text</option>
            $("#AuthorID").append(`<option value="${data.id}">` + data.name + "</option>")
        },  
    });

    
});

$("#addNewPublisher").click(function () {
    console.log("modal button publisher add new publisher");


});

$("#addNewCategory").click(function () {
    console.log("modal button category add new category");

});


