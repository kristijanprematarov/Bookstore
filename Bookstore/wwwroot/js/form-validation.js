
// ********************************************************* BOOK CREATE *********************************************************

$(function () {

    $("form[name='bookcreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
            //if invalid add this class to the field
            //highlight fields when error
            //function (element, errorClass) --> element --> the element | errorClass --> the class to be added if invalid
        },
        rules: { //SPECIFY VALIDATION RULES
            BookTitle: {
                required: true,
                minlength: 2 //minimum 2 bukvi u title-ot
            },
            YearOfIssue: {
                required: true
            }, //ako e samo eden rule go pisuvame vaka kako string
            NumberOfPages: {
                required: true,
                number: true, //samo number moze da vnesis drugo se ke smetam deka e nevalidno
                digits: true, // da prifakja samo brojki
                min: 10 //minimum --> number >= 10;
            },
            Genre: {
                required: true
            },
            //publisher name ni e hidden pole i ako napravam validacija na hidden pole nema da ni dade nisto da postneme ne go gleame
            //
            PublisherID: {
                required: true,
                min: 1 // da mozes minimum eden da odberes, koga ke kliknam na publisherID imame select publisher on ako a zeme nulata primer toa so e option 0 --> select publisher toa ima 0 id a nie vo nasiot sistem nemam id i ke pojavuva greska
            },
            CategoryID: {
                required: true,
                min: 1
            },
            AuthorID: {
                required: true,
                min: 1
            },
            Price: {
                required: true,
                number: true,
                digits: true
            },
            BookType: {
                required: true
            },
            BookCoverType: {
                required: true
            },
            Copies: {
                required: true,
                number: true,
                digits: true
            },
            Dimensions: {
                required: true,
            },
            Edition: {
                required: true,
                number: true,
                digits: true,
                min: 1 //poso nema da e edition nula neli..
            },
            Language: {
                required: true
            },
            Shipping: {
                required: true
            },
            Weight: {
                required: true,
                number: true,
                digits: true
            },
            Country: {
                required: true
            },
            Description: {
                required: true
            },
            SoldItems: {
                required: true,
                number: true,
                digits: true
            },
            Rating: {
                required: true
            }
        },
        messages: { // SPECIFY VALIDATION ERROR MESSAGES
            BookTitle: {
                required: "Please enter title",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            YearOfIssue: {
                required: "Please enter year of issue"
            },
            NumberOfPages: {
                required: "Please enter number of pages",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field",
                min: jQuery.validator.format("At least number {0} required") //minimum --> number >= 10;
            },
            Genre: {
                required: "Please enter genre of the book"
            },
            //publisher name ni e hidden pole i ako napravam validacija na hidden pole nema da ni dade nisto da postneme ne go gleame
            PublisherID: {
                required: "Please choose publisher",
                min: "Please select one publisher from the dropdown" // da mozes minimum eden da odberes, koga ke kliknam na publisherID imame select publisher on ako a zeme nulata primer toa so e option 0 --> select publisher toa ima 0 id a nie vo nasiot sistem nemam id i ke pojavuva greska
            },
            CategoryID: {
                required: "Please choose category",
                min: "Please select one category from the dropdown"
            },
            AuthorID: {
                required: "Please choose author, or create a new one",
                min: "Please select one author from dropdown"
            },
            Price: {
                required: "Please enter the price of the book",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            BookType: {
                required: "Please enter book type"
            },
            BookCoverType: {
                required: "Please enter book cover type"
            },
            Copies: {
                required: "Please enter the copies of the book",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            Dimensions: {
                required: "Please enter dimensions of the book",
            },
            Edition: {
                required: "Please enter the edition of the book",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field",
                min: jQuery.validator.format("At least number {0} required")
            },
            Language: {
                required: "Please enter the language of the book"
            },
            Shipping: {
                required: "Please enter shipping"
            },
            Weight: {
                required: "Please enter the weight of the book",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            Country: {
                required: "Please enter the country of origin"
            },
            Description: {
                required: "Please enter description of the book"
            },
            SoldItems: {
                required: "Please enter the number of sold items",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            Rating: {
                required: "Please enter the rating of the book",
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });

});

// ********************************************************* CATEGORY *********************************************************

$(function () {

    $("form[name='categorycreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: { 
            Name: {
                required: true,
                minlength: 2 
            }
        },
        messages: { // SPECIFY VALIDATION ERROR MESSAGES
            Name: {
                required: "Please enter category name",
                minlength: jQuery.validator.format("At least {0} characters required")
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });

});

// ********************************************************* AUTHOR *********************************************************

$(function () {

    $("form[name='authorcreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: {
            Name: {
                required: true,
                minlength: 2
            },
            Country: {
                required: true,
                minlength: 2
            },
            DateBirth: {
                required: true
            },
            ShortDescription: {
                required: true,
                minlength: 2
            },
            Language: {
                required: true
            },
            Gender: {
                required: true
            }
        },
        messages: { // SPECIFY VALIDATION ERROR MESSAGES
            Name: {
                required: "Please enter the name of the Author",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            Country: {
                required: "Please enter country",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            DateBirth: {
                required: "Please choose the date of birth",
            },
            ShortDescription: {
                required: "Please write a shord description",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            Language: {
                required: "Please enter language",
            },
            Gender: {
                required: "Please enter gender",
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });

});

// ********************************************************* PUBLISHER *********************************************************

$(function () {

    $("form[name='publishercreate']").validate({
        success: "valid",
        onkeyup: true,
        focusInvalid: true,
        errorClass: "error",
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: {
            Name: {
                required: true,
                minlength: 2
            },
            Country: {
                required: true,
                minlength: 2
            },
            Year: {
                required: true
            }
        },
        messages: { // SPECIFY VALIDATION ERROR MESSAGES
            Name: {
                required: "Please enter the name of the Publisher",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            Country: {
                required: "Please enter country",
                minlength: jQuery.validator.format("At least {0} characters required")
            },
            Year: {
                required: "Please choose the date of birth",
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    });

});

