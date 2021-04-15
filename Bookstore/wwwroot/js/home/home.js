//$(document).ready(function () {
//    console.log("home loaded!");
//    $.ajax({
//        type: "GET",
//        url: "Book/GetAllBooksAJAX",
//        success: function (data) {
//            console.log(data);
//            //console.log(data.booksData[1].title);
//            //$("#bookTitleFromJson").val(data.booksData[1].title);
//        },
//        error: function () {
//            alert("Error getting all books!");
//        }
//    })
//});


$(document).ready(function () {

    GetQuotes();

    setInterval(GetQuotes, 15000);

    //setInterval(() => {
    //    GetQuotes();
    //    15000;
    //});

});


function GetQuotes() {
    $.ajax({
        type: "GET",
    /*url: "https://type.fit/api/quotes",*/ //option if there is no cors
        url: "/Home/GetQuotes",
        success: function (data) {

            $("#quote").text("\" " + data.quotes[0].quote + "\""); //quotes[0] because it will iterate through every response and the list will always have 1 element
            $("#quote_author").text("\" " + data.quotes[0].author + "\"");

            var quoteTags = data.quotes[0].tags;
            var tagsString = "";

            quoteTags.forEach(item => {
                var lastItem = quoteTags[quoteTags.length - 1];
                tagsString += item == lastItem ? item + "" : item + ", ";
            });
            $("#quote_tags").text(tagsString);
        },
        error: function () {
            alert("Error getting quotes");
        }
    })
};
