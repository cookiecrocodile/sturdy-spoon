$(document).ready(function () {

    $("#addButton").on("click", function (e) {
        e.preventDefault();

        //var name = $('#recipeName').val();
        var checkboxes = [];

        $("#checkboxDiv input:checked").each(function () {
            checkboxes.push($(this).attr('name'));
        }); //checkboxdiv each

        //var url = $("#fileLocation").val();


        $.ajax({
            method: 'GET',
            url: '/StorageApi/ValidateRecipe',
            data: {
                name: $('#recipeName').val(),
                categories: checkboxes.toString(),
                url: $("#fileLocation").val(),
                tags: $("#tags").val()
            },
            dataType: 'json',
            error: function () {
                alert('Error!');
            },
            success: function (data) {
                if (data.IsValid) {
                    alert("submitting form");
                    $("#addRecipeForm").submit();
                }
                else {
                    $("#validation").html(data.ValidationMessage);
                }

                //If valid, post the form
                //else show the ValidationMessage
            }
        });

    });//addButton on click
});//document ready