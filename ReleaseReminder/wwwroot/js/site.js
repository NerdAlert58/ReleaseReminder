// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Getting values for the drop downs for future manipulation
var select1 = document.getElementById("genre1");
var select2 = document.getElementById("genre2");
var select3 = document.getElementById("genre3");

//Disabling genre dropdowns until media is selected
select1.disabled = true;
select2.disabled = true;
select3.disabled = true;

//calls the function to color code the table


//globablly declaring the dropdown list for genre that will be received from ajax call to controller. 
var genreDropdownList;

//Media stores the value of media type selected, declared globally because used it multiple places.
var media = "";
getGenresAjax();
generateDropdown();
tableFilter();


//updates every time a media type is selected
function mediaSelect(selectObject) { 
    var value = selectObject.value;

    //assign value for global media which will be used in the filtering table
    if (value == "Movies") {
        media = "Movies";
    } else if (value == "VideoGames") {
        media = "VideoGames";
    } else if (value == "Music") {
        media = "Music";
    } else if (value == "Books") {
        media = "Books";
    } else if (value == "Television") {
        media = "Television";
    } else {
        media = ""; //else it is ALL, which should do no filtering
    }

    getGenresAjax();   

    //disabling the second and third genre select while the first is set to all. No functionality, but looks better
    select2.disabled = true; 
    select3.disabled = true;

    //calls to the generateDropdown function to be able to fill the genre drop downs with proper options
    generateDropdown();

    //calling table filter to update the filter based on current media type selection
    tableFilter();
}

function getGenresAjax() {
    $.ajax({
        type: "POST",
        url: "getGenres",
        async: false, //has to be ansychronous, small amounts of data but need it before other values
        data: JSON.stringify(media),
        contentType: "application/json;charset=utf-8",
        dataType: "text",
        success: function (result) {
            genreDropdownList = result; //this is where we fill the genreDropdownList variable declared globablly with data from home controller
        },
        error: function (response) {
            debugger;
            alert('error');
        }
    });

}

function generateDropdown() {

    //getting the json from the controller and changing it ot a string
    var genreString = $.parseJSON(genreDropdownList);

    // ----------------------------------------------------------------------------------------------------------------------------------------------------Divison to make code easier to read
    function fillSelect1(select) { //this function is used for filling the options in genre select 1, seperate function because it has an ALL option
        var length = select.options.length;

        for (i = select.options.length - 1; i >= 0; i--) { //starts by clearing the options to prevent reselecting from having a building
            select.remove(i); //removing the options
        }


        for (var i = 0; i < genreString.length + 1; i++) { //getting values from the list of strings
            var option = document.createElement("OPTION"); //creating the option
            var txt;

            if (i == 0) {
                txt = document.createTextNode("All"); //manually adding the ALL category at top
                option.appendChild(txt); //appending the all option
                option.setAttribute("value", ""); //adding the attribute of value, which is what we get back on selection
                select.insertBefore(option, select.lastChild); // inserting the new option into dropdown object
            } else {
                txt = document.createTextNode(genreString[i - 1]); //dynamically adding the list of genres
                option.appendChild(txt);
                option.setAttribute("value", genreString[i - 1]);
                select.insertBefore(option, select.lastChild);
            }
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------------------------Divison to make code easier to read
    function fillSelect2(select) { //used to fill options in genre select 2 and 3. Has "none" option
        var length = select.options.length; 

        for (i = select.options.length - 1; i >= 0; i--) {
            select.remove(i);
        }


        for (var i = 0; i < genreString.length + 1; i++) { //Code is extremely similar to fillSelect1, look at that for comments
            var option = document.createElement("OPTION");
            var txt;

            if (i == 0) {
                txt = document.createTextNode("None");
                option.appendChild(txt);
                option.setAttribute("value", "rewhuiqwhuewquhiewquihwq"); //weird value to make sure it isnt a genre (so on none it doesnt have anything to filter)
                select.insertBefore(option, select.lastChild);
            } else {
                txt = document.createTextNode(genreString[i - 1]);
                option.appendChild(txt);
                option.setAttribute("value", genreString[i - 1]);
                select.insertBefore(option, select.lastChild);
            }
        }
    }

    //calling the functions to fill in dropdown 1-3
    fillSelect1(select1);
    fillSelect2(select2);
    fillSelect2(select3);
    //enabling the first 1. Is automatically going to be on ALL, others will be enabled when it changes to something more specific
    select1.disabled = false;

}

function genreFilter(select) { //is called when Genre dropdown 1 changes values
    if (select.value != "") { //if the it not the ALL option, enable other two dropdowns
        select2.disabled = false; //enabling the dropdowns
        select3.disabled = false;
    }

    tableFilter(); //calling function to update filter now that new genre has been selected. The other two dropdowns automatically call the filter function on change.
}

function tableFilter() {
    var  table, tr, i; //delcaring varibles that will be used throughout,
    var mediaFilter = media.toUpperCase(); //filter for media column

    var textFilter = document.getElementById("filterText").value.toUpperCase(); //filter for text column, gets updated per key up


    table = document.getElementById("formTable"); //getting table from view to edit

    tr = table.getElementsByTagName("tr"); //defining rows

    var genreFilter1, genreFilter2, genreFilter3;

        genreFilter1 = select1.value.toUpperCase(); //value of the first genre filter

    if (genreFilter1 == "") { //if the first genre dropdown is all, then no genre filtering
        genreFilter2 = "";
        genreFilter3 = "";
    } else {
        genreFilter2 = select2.value.toUpperCase(); //not all, filter the values of the other two dropdowns
        genreFilter3 = select3.value.toUpperCase();
    }


    // Loop through all table rows, and hide those who don't match the search query
    for (i = 1; i < tr.length; i++) { //i = 1 to avoid headers
        mediaType = tr[i].getElementsByTagName("td")[4]; //column 5, which is the media type
        Title = tr[i].getElementsByTagName("td")[1]; //column 2, the title
        genreType = tr[i].getElementsByTagName("td")[2]; //column 3, the genre

        //below, filtering is strange. Think of doing && as a union and || as intersection
        if (mediaType) {
            if (Title.innerHTML.toUpperCase().indexOf(textFilter) > -1 && mediaType.innerHTML.toUpperCase().indexOf(mediaFilter) > -1
                && (genreType.innerHTML.toUpperCase().indexOf(genreFilter1) > -1 || genreType.innerHTML.toUpperCase().indexOf(genreFilter2) > -1 || genreType.innerHTML.toUpperCase().indexOf(genreFilter3) > -1)){ 
                tr[i].style.display = ""; //keep displaying the item
            } else {
                tr[i].style.display = "none"; //hide the item (not deleting, just hiding)
            }
        }
    }
}


function selectedData() { //Function for sending the selected data back to controller
    var table = document.getElementById("formTable");

    var count = 0; //used for filling the string array in order
    var stringArray = new Array();

    for (var i = 1, row; row = table.rows[i]; i++) { //avoiding first row because it's just the headers
        if (row.cells[0].children[0].checked) { //checking the first rows textbox to see if they are checked
            stringArray[count] = row.cells[1].innerHTML; //if checked, getting the title data of that row and sending it
            count++;
        }
    }
    var postData = {
        values: stringArray
    };
    $.ajax({ //ajax call to post the reminders
        type: "POST",
        url: "/Home/reminderSubmission",
        data: postData,
        success: function (data) {
            alert("Successfully Submitted your Reminders. Go to Subscribed Reminders to View to see what you are subscribed to.");
            window.location.replace("/home/displaySelected");

        },
        dataType: "json",
        traditional: true
    });
}

