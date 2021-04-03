//$(document).ready(function () { });

$(document).ready(function () {
    console.log('Document is ready!!!');
});


$("#AuthorID").change(function () {

    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    //js
    //var getVal = document.getElementById("AuthorName").value;
    //jquery
    //var $("#AuthorName").val();

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

    var data = {
        Name: $("#AuthorNameDTO").val(),
        Country: $("#AuthorCountryDTO").val(),
        DateBirth: $("#AuthorDateBirthDTO").val(),
        ShortDescritpion: $("#AuthorShortDescriptionDTO").val(),
        Language: $("#AuthorLanguageDTO").val(),
        Gender: $("#AuthorGenderDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Author/CreateAuthorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            //console.log(data);
            if (data.name !== null) {
                // AuthorID
                $("#AuthorID").append("<option value=" + data.id + ">" + data.name + "</option>");
                $('#authorAddedModal').modal('toggle');
                $('#authorModal').modal('toggle');
            } else {
                $('#authorModal').modal('toggle');
                $('#authorNotAddedModal').modal('toggle');
            }
        },
        error: function () {
            $('#authorNotAddedModal').modal('toggle');
        }
    });

});

$("#addNewPublisher").click(function () {
    console.log("modal button publisher add new publisher");

    var data = {
        Name: $("#PublisherNameDTO").val(),
        Country: $("#PublisherCountryDTO").val(),
        Year: $("#PublisherYearDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Publisher/CreatePublisherAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            if (data.name !== null) {
                // PublisherID
                $("#PublisherID").append("<option value=" + data.id + ">" + data.name + "</option>");
                $('#publisherAddedModal').modal('toggle');
                $('#publisherModal').modal('toggle');
            } else {
                $('#publisherModal').modal('toggle');
                $('#publisherNotAddedModal').modal('toggle');
            }
        },
        error: function () {
            $('#publisherNotAddedModal').modal('toggle');
        }
    });
});

$("#addNewCategory").click(function () {
    console.log("modal button category add new category");

    var data = {
        Name: $("#CategoryNameDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Category/CreateCategoryAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            if (data.name !== null) {
                // CategoryID
                $("#CategoryID").append("<option value=" + data.id + ">" + data.name + "</option>");
                $('#categoryAddedModal').modal('toggle');
                $('#categoryModal').modal('toggle');
            } else {
                $('#categoryModal').modal('toggle');
                $('#categoryNotAddedModal').modal('toggle');
            }
        },
        error: function () {
            $('#categoryNotAddedModal').modal('toggle');
        }
    });
});

$("#uploadPhoto").click(function () {

    var data = new FormData();

    var files = $("#photoUpload").get(0).files;

    if (files.length > 0) {
        data.append("UploadedImage", files[0]);
    }

    $.ajax({

        type: "POST",
        url: "/Book/UploadPhoto",
        data: data,
        contentType: false,
        processData: false,
        success: function (data) {
            console.log(data.dbPath);
            $("#PhotoURL").val(data.dbPath);
        },
        error: function () {
            alert("Error uploading photo!");
        }
    });

});
