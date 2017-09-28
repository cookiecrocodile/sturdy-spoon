$(document).ready(function () {

    var url = '@Url.Action("SearchResult", "Recipe")';

    $('#searchButton').click(function () {
        var keyWord = $('#searchBox').val();
        $('#searchResults').load(url, { searchText: keyWord });
    });

    //$("#searchBox").on("change", function (e)
    //{

    //});

    //$("#searchButton").on("click", function ()
    //{
    //    //Detta är ett exempel, inte kod som går att använda som den är
    //    $.ajax({
    //        method: 'GET',
    //        url: '/Api/Recipe',
    //        data: {
    //            searchString: username //User input
    //        },

    //        dataType: 'json',
    //        error: function () {
    //            alert('Error!');
    //        },

    //        success: function (data) {
    //            if (data === "Taken") {

    //                usernameInput.css("background-color", "red");
    //                correctUsername = false;
    //            }

    //            else if (data === "Available") {

    //                usernameInput.css("background-color", "lightgreen");
    //                correctUsername = true;
    //            }
    //        }
    //    });
    //});
});