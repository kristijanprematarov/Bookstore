﻿$(document).ready(function () {
    console.log("home loaded!");
    $.ajax({
        type: "GET",
        url: "Book/GetAllBooksAJAX",
        success: function (data) {
            console.log(data);
            //console.log(data.booksData[1].title);
            //$("#bookTitleFromJson").val(data.booksData[1].title);
        },
        error: function () {
            alert("Error getting all books!");
        }
    })
});